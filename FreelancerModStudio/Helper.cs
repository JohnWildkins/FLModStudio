using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace FreelancerModStudio
{
    class Helper
    {
        public struct Program
        {
            public static void Start()
            {
                //load settings
                Settings.Load();
                Template.Load();

                FreelancerModStudio.Settings.Template.File a = Template.Data.Data.Files[Template.Data.Data.Files.IndexOf("system")];
                List<FreelancerModStudio.Settings.TemplateINIBlock> b = FreelancerModStudio.Settings.FileManager.Read(a, @"E:\DAT\Downloads\1.5b15-sdk_20050627\Universe\Systems\Br01\Br01.ini");

                if (Settings.Data.Data.General.AutoUpdate.Update.Downloaded)
                {
                    //install update
                    AutoUpdate.AutoUpdate autoUpdate = new AutoUpdate.AutoUpdate("", "", "", null, false, false);
                    autoUpdate.Install();
                }
                else
                {
                    //remove installed update
                    if (Settings.Data.Data.General.AutoUpdate.Update.Installed)
                        AutoUpdate.AutoUpdate.RemoveUpdate();

                    //download update
                    if (Settings.Data.Data.General.AutoUpdate.Enabled && Settings.Data.Data.General.AutoUpdate.NewestVersionFile != null && Settings.Data.Data.General.AutoUpdate.LastCheck.Date.AddDays(Settings.Data.Data.General.AutoUpdate.CheckInterval) <= DateTime.Now.Date)
                    {
                        //download in thread with lowest performance
                        System.Threading.Thread autoUpdateThread = new System.Threading.Thread(new System.Threading.ThreadStart( delegate
                        {
                            string proxy = "";
                            string username = "";
                            string password = "";

                            if (Settings.Data.Data.General.AutoUpdate.Proxy.Enabled)
                            {
                                proxy = Settings.Data.Data.General.AutoUpdate.Proxy.Uri;
                                username = Settings.Data.Data.General.AutoUpdate.Proxy.Username;
                                password = Settings.Data.Data.General.AutoUpdate.Proxy.Password;
                            }

                            AutoUpdate.AutoUpdate autoUpdate = new AutoUpdate.AutoUpdate(proxy, username, password, new Uri(Settings.Data.Data.General.AutoUpdate.NewestVersionFile), true, Settings.Data.Data.General.AutoUpdate.SilentDownload);
                            autoUpdate.Check();
                        }));
                        autoUpdateThread.Priority = System.Threading.ThreadPriority.Lowest;
                        autoUpdateThread.IsBackground = true;
                        autoUpdateThread.Start();
                    }

                    //start main form
                    Application.Run(new frmMain());
                }

                //save settings
                Helper.Settings.Save();
            }
        }

        public struct Template
        {
            public static FreelancerModStudio.Settings.Template Data;

            public static void Load()
            {
                string File = System.IO.Path.Combine(Application.StartupPath, Properties.Resources.TemplatePath);
                Data = new FreelancerModStudio.Settings.Template();

                try
                {
                    Data.Load(File);
                }
                catch (Exception ex)
                {
                    Helper.Exceptions.Show(new Exception(String.Format(Properties.Strings.LoadTemplateException, Properties.Resources.TemplatePath), ex));
                    Environment.Exit(0);
                }
            }
        }

        public struct Settings
        {
            public static FreelancerModStudio.Settings.Settings Data;

            public static void Save()
            {
                try
                {
                    Data.Save(System.IO.Path.Combine(Application.StartupPath, Properties.Resources.SettingsPath));
                }
                catch (Exception ex)
                {
                    Helper.Exceptions.Show(new Exception(String.Format(Properties.Strings.SaveSettingsException, Properties.Resources.SettingsPath), ex));
                }
            }

            public static void Load()
            {
                string File = System.IO.Path.Combine(Application.StartupPath, Properties.Resources.SettingsPath);
                Data = new FreelancerModStudio.Settings.Settings();

                if (System.IO.File.Exists(File))
                {
                    try
                    {
                        Data.Load(File);
                    }
                    catch (Exception ex)
                    {
                        Helper.Exceptions.Show(new Exception(String.Format(Properties.Strings.LoadSettingsException, Properties.Resources.SettingsPath), ex));
                    }
                }
            }
        }

        public struct Thread
        {
            public static void Start(ref System.Threading.Thread thread, System.Threading.ThreadStart threadDelegate, System.Threading.ThreadPriority priority, bool isBackground)
            {
                Abort(ref thread, true);

                thread = new System.Threading.Thread(threadDelegate);
                thread.Priority = priority;
                thread.IsBackground = isBackground;

                thread.Start();
            }

            public static void Abort(ref System.Threading.Thread thread, bool wait)
            {
                if (IsRunning(ref thread))
                {
                    thread.Abort();

                    if (wait)
                        thread.Join();
                }
            }

            public static bool IsRunning(ref System.Threading.Thread thread)
            {
                return (thread != null && thread.IsAlive);
            }
        }

        public struct Compare
        {
            public static bool Size(Point checkSize, Point currentSize, bool bigger)
            {
                return Size(new Size(checkSize.X, checkSize.Y), new Size(currentSize.X, currentSize.Y), bigger);
            }

            public static bool Size(Size checkSize, Size currentSize, bool bigger)
            {
                if (bigger)
                    return (checkSize.Width >= currentSize.Width && checkSize.Height >= currentSize.Height);
                else
                    return (checkSize.Width <= currentSize.Width && checkSize.Height <= currentSize.Height);
            }
        }

        public struct Exceptions
        {
            public static void Show(Exception exception)
            {
                MessageBox.Show(Get(exception), Assembly.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            private static string Get(Exception exception)
            {
                System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder(exception.Message);

                if (exception.InnerException != null)
                    stringBuilder.Append(Environment.NewLine + Environment.NewLine + Get(exception.InnerException).ToString());

                return stringBuilder.ToString();
            }
        }

        public struct Assembly
        {
            public static string Title
            {
                get
                {
                    // Alle Title-Attribute in dieser Assembly abrufen
                    object[] attributes = System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Reflection.AssemblyTitleAttribute), false);
                    // Wenn mindestens ein Title-Attribut vorhanden ist
                    if (attributes.Length > 0)
                    {
                        // Erstes ausw�hlen
                        System.Reflection.AssemblyTitleAttribute titleAttribute = (System.Reflection.AssemblyTitleAttribute)attributes[0];
                        // Zur�ckgeben, wenn es keine leere Zeichenfolge ist
                        if (titleAttribute.Title != "")
                            return titleAttribute.Title;
                    }
                    // Wenn kein Title-Attribut vorhanden oder das Title-Attribut eine leere Zeichenfolge war, den EXE-Namen zur�ckgeben
                    return System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
                }
            }

            public static Version Version
            {
                get
                {
                    return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                }
            }

            public static string Description
            {
                get
                {
                    // Alle Description-Attribute in dieser Assembly abrufen
                    object[] attributes = System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Reflection.AssemblyDescriptionAttribute), false);
                    // Eine leere Zeichenfolge zur�ckgeben, wenn keine Description-Attribute vorhanden sind
                    if (attributes.Length == 0)
                        return "";
                    // Den Wert des Description-Attributs zur�ckgeben, wenn eines vorhanden ist
                    return ((System.Reflection.AssemblyDescriptionAttribute)attributes[0]).Description;
                }
            }

            public static string Product
            {
                get
                {
                    // Alle Product-Attribute in dieser Assembly abrufen
                    object[] attributes = System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Reflection.AssemblyProductAttribute), false);
                    // Eine leere Zeichenfolge zur�ckgeben, wenn keine Product-Attribute vorhanden sind
                    if (attributes.Length == 0)
                        return "";
                    // Den Wert des Product-Attributs zur�ckgeben, wenn eines vorhanden ist
                    return ((System.Reflection.AssemblyProductAttribute)attributes[0]).Product;
                }
            }

            public static string Copyright
            {
                get
                {
                    // Alle Copyright-Attribute in dieser Assembly abrufen
                    object[] attributes = System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Reflection.AssemblyCopyrightAttribute), false);
                    // Eine leere Zeichenfolge zur�ckgeben, wenn keine Copyright-Attribute vorhanden sind
                    if (attributes.Length == 0)
                        return "";
                    // Den Wert des Copyright-Attributs zur�ckgeben, wenn eines vorhanden ist
                    return ((System.Reflection.AssemblyCopyrightAttribute)attributes[0]).Copyright;
                }
            }

            public static string Company
            {
                get
                {
                    // Alle Company-Attribute in dieser Assembly abrufen
                    object[] attributes = System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Reflection.AssemblyCompanyAttribute), false);
                    // Eine leere Zeichenfolge zur�ckgeben, wenn keine Company-Attribute vorhanden sind
                    if (attributes.Length == 0)
                        return "";
                    // Den Wert des Company-Attributs zur�ckgeben, wenn eines vorhanden ist
                    return ((System.Reflection.AssemblyCompanyAttribute)attributes[0]).Company;
                }
            }
        }
    }
}