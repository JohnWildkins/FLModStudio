﻿namespace FreelancerModStudio
{
    using System.ComponentModel;
    using System.Windows.Forms;

    using WeifenLuo.WinFormsUI.Docking;

    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripPanel1 = new System.Windows.Forms.ToolStripPanel();
            this.toolStripPanel2 = new System.Windows.Forms.ToolStripPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewMod = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenMod = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecentFilesSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCloseSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseMod = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGoTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSolutionExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu3dEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFocusSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLookAtSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrackSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFocusSelectedSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuManipulationNone = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManipulationTranslate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManipulationRotate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManipulationScale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManipulationSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuShowModels = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeVisibility = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowModelsSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFullScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCloseAllDocuments = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResetLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowsSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisitForum = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPanel3 = new System.Windows.Forms.ToolStripPanel();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPanel4 = new System.Windows.Forms.ToolStripPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuClose2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseOther = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCloseAllUnchanged = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCloseAllToLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCloseAllToRight = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopyFullPathSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCopyFullPath = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenContainingFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripPanel1
            // 
            resources.ApplyResources(this.toolStripPanel1, "toolStripPanel1");
            this.toolStripPanel1.Name = "toolStripPanel1";
            this.toolStripPanel1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.toolStripPanel1.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            // 
            // toolStripPanel2
            // 
            this.toolStripPanel2.Controls.Add(this.menuStrip1);
            resources.ApplyResources(this.toolStripPanel2, "toolStripPanel2");
            this.toolStripPanel2.Name = "toolStripPanel2";
            this.toolStripPanel2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripPanel2.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView,
            this.mnuTools,
            this.mnuWindows,
            this.mnuHelp});
            this.menuStrip1.MdiWindowListItem = this.mnuWindows;
            this.menuStrip1.Name = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem6,
            this.mnuOpen,
            this.mnuCloseSeperator,
            this.mnuClose,
            this.mnuCloseMod,
            this.mnuSaveSeperator,
            this.mnuRefresh,
            this.toolStripSeparator1,
            this.mnuSave,
            this.mnuSaveAs,
            this.mnuSaveAll,
            this.toolStripMenuItem8,
            this.mnuExit});
            this.mnuFile.MergeIndex = 0;
            this.mnuFile.Name = "mnuFile";
            resources.ApplyResources(this.mnuFile, "mnuFile");
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewMod,
            this.mnuNewFile});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            // 
            // mnuNewMod
            // 
            resources.ApplyResources(this.mnuNewMod, "mnuNewMod");
            this.mnuNewMod.Image = global::FreelancerModStudio.Properties.Resources.NewMod;
            this.mnuNewMod.Name = "mnuNewMod";
            // 
            // mnuNewFile
            // 
            this.mnuNewFile.Image = global::FreelancerModStudio.Properties.Resources.NewDocument;
            this.mnuNewFile.Name = "mnuNewFile";
            resources.ApplyResources(this.mnuNewFile, "mnuNewFile");
            this.mnuNewFile.Click += new System.EventHandler(this.MnuNewFileClick);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            // 
            // mnuOpen
            // 
            this.mnuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenMod,
            this.mnuOpenFile,
            this.mnuRecentFilesSeperator});
            this.mnuOpen.Name = "mnuOpen";
            resources.ApplyResources(this.mnuOpen, "mnuOpen");
            // 
            // mnuOpenMod
            // 
            resources.ApplyResources(this.mnuOpenMod, "mnuOpenMod");
            this.mnuOpenMod.Image = global::FreelancerModStudio.Properties.Resources.OpenMod;
            this.mnuOpenMod.Name = "mnuOpenMod";
            this.mnuOpenMod.Click += new System.EventHandler(this.MnuOpenModClick);
            // 
            // mnuOpenFile
            // 
            this.mnuOpenFile.Image = global::FreelancerModStudio.Properties.Resources.Open;
            this.mnuOpenFile.Name = "mnuOpenFile";
            resources.ApplyResources(this.mnuOpenFile, "mnuOpenFile");
            this.mnuOpenFile.Click += new System.EventHandler(this.MnuOpenFileClick);
            // 
            // mnuRecentFilesSeperator
            // 
            this.mnuRecentFilesSeperator.Name = "mnuRecentFilesSeperator";
            resources.ApplyResources(this.mnuRecentFilesSeperator, "mnuRecentFilesSeperator");
            // 
            // mnuCloseSeperator
            // 
            this.mnuCloseSeperator.Name = "mnuCloseSeperator";
            resources.ApplyResources(this.mnuCloseSeperator, "mnuCloseSeperator");
            // 
            // mnuClose
            // 
            resources.ApplyResources(this.mnuClose, "mnuClose");
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Click += new System.EventHandler(this.MnuCloseClick);
            // 
            // mnuCloseMod
            // 
            resources.ApplyResources(this.mnuCloseMod, "mnuCloseMod");
            this.mnuCloseMod.Image = global::FreelancerModStudio.Properties.Resources.CloseMod;
            this.mnuCloseMod.Name = "mnuCloseMod";
            // 
            // mnuSaveSeperator
            // 
            this.mnuSaveSeperator.Name = "mnuSaveSeperator";
            resources.ApplyResources(this.mnuSaveSeperator, "mnuSaveSeperator");
            // 
            // mnuSave
            // 
            resources.ApplyResources(this.mnuSave, "mnuSave");
            this.mnuSave.Image = global::FreelancerModStudio.Properties.Resources.Save;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Click += new System.EventHandler(this.MnuSaveClick);
            // 
            // mnuSaveAs
            // 
            resources.ApplyResources(this.mnuSaveAs, "mnuSaveAs");
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Click += new System.EventHandler(this.MnuSaveAsClick);
            // 
            // mnuSaveAll
            // 
            resources.ApplyResources(this.mnuSaveAll, "mnuSaveAll");
            this.mnuSaveAll.Image = global::FreelancerModStudio.Properties.Resources.SaveAll;
            this.mnuSaveAll.Name = "mnuSaveAll";
            this.mnuSaveAll.Click += new System.EventHandler(this.MnuSaveAllClick);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            resources.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            resources.ApplyResources(this.mnuExit, "mnuExit");
            this.mnuExit.Click += new System.EventHandler(this.MnuExitClick);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUndo,
            this.mnuRedo,
            this.toolStripSeparator2,
            this.mnuCut,
            this.mnuCopy,
            this.mnuPaste,
            this.toolStripMenuItem4,
            this.mnuAdd,
            this.mnuDelete,
            this.mnuGoTo,
            this.toolStripSeparator4,
            this.mnuSelectAll});
            this.mnuEdit.Name = "mnuEdit";
            resources.ApplyResources(this.mnuEdit, "mnuEdit");
            // 
            // mnuUndo
            // 
            resources.ApplyResources(this.mnuUndo, "mnuUndo");
            this.mnuUndo.Image = global::FreelancerModStudio.Properties.Resources.ReDo;
            this.mnuUndo.Name = "mnuUndo";
            this.mnuUndo.Click += new System.EventHandler(this.MnuUndoClick);
            // 
            // mnuRedo
            // 
            resources.ApplyResources(this.mnuRedo, "mnuRedo");
            this.mnuRedo.Image = global::FreelancerModStudio.Properties.Resources.UnDo;
            this.mnuRedo.Name = "mnuRedo";
            this.mnuRedo.Click += new System.EventHandler(this.MnuRedoClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // mnuCut
            // 
            resources.ApplyResources(this.mnuCut, "mnuCut");
            this.mnuCut.Image = global::FreelancerModStudio.Properties.Resources.Cut;
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.Click += new System.EventHandler(this.MnuCutClick);
            // 
            // mnuCopy
            // 
            resources.ApplyResources(this.mnuCopy, "mnuCopy");
            this.mnuCopy.Image = global::FreelancerModStudio.Properties.Resources.Copy;
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Click += new System.EventHandler(this.MnuCopyClick);
            // 
            // mnuPaste
            // 
            resources.ApplyResources(this.mnuPaste, "mnuPaste");
            this.mnuPaste.Image = global::FreelancerModStudio.Properties.Resources.Paste;
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.Click += new System.EventHandler(this.MnuPasteClick);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // mnuAdd
            // 
            resources.ApplyResources(this.mnuAdd, "mnuAdd");
            this.mnuAdd.Image = global::FreelancerModStudio.Properties.Resources.Add;
            this.mnuAdd.Name = "mnuAdd";
            // 
            // mnuDelete
            // 
            resources.ApplyResources(this.mnuDelete, "mnuDelete");
            this.mnuDelete.Image = global::FreelancerModStudio.Properties.Resources.Delete;
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Click += new System.EventHandler(this.MnuDeleteClick);
            // 
            // mnuGoTo
            // 
            resources.ApplyResources(this.mnuGoTo, "mnuGoTo");
            this.mnuGoTo.Image = global::FreelancerModStudio.Properties.Resources.GoTo;
            this.mnuGoTo.Name = "mnuGoTo";
            this.mnuGoTo.Click += new System.EventHandler(this.MnuGoToClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // mnuSelectAll
            // 
            resources.ApplyResources(this.mnuSelectAll, "mnuSelectAll");
            this.mnuSelectAll.Name = "mnuSelectAll";
            this.mnuSelectAll.Click += new System.EventHandler(this.MnuSelectAllClick);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSolutionExplorer,
            this.mnuProperties,
            this.mnu3dEditor,
            this.toolStripMenuItem3,
            this.mnuFocusSelected,
            this.mnuLookAtSelected,
            this.mnuTrackSelected,
            this.mnuFocusSelectedSeperator,
            this.mnuManipulationNone,
            this.mnuManipulationTranslate,
            this.mnuManipulationRotate,
            this.mnuManipulationScale,
            this.mnuManipulationSeperator,
            this.mnuShowModels,
            this.mnuChangeVisibility,
            this.mnuShowModelsSeperator,
            this.mnuFullScreen});
            this.mnuView.MergeIndex = 2;
            this.mnuView.Name = "mnuView";
            resources.ApplyResources(this.mnuView, "mnuView");
            // 
            // mnuSolutionExplorer
            // 
            resources.ApplyResources(this.mnuSolutionExplorer, "mnuSolutionExplorer");
            this.mnuSolutionExplorer.Name = "mnuSolutionExplorer";
            this.mnuSolutionExplorer.Click += new System.EventHandler(this.MnuSolutionExplorerClick);
            // 
            // mnuProperties
            // 
            this.mnuProperties.Name = "mnuProperties";
            resources.ApplyResources(this.mnuProperties, "mnuProperties");
            this.mnuProperties.Click += new System.EventHandler(this.MnuPropertiesClick);
            // 
            // mnu3dEditor
            // 
            resources.ApplyResources(this.mnu3dEditor, "mnu3dEditor");
            this.mnu3dEditor.Name = "mnu3dEditor";
            this.mnu3dEditor.Click += new System.EventHandler(this.Mnu3dEditorClick);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // mnuFocusSelected
            // 
            resources.ApplyResources(this.mnuFocusSelected, "mnuFocusSelected");
            this.mnuFocusSelected.Name = "mnuFocusSelected";
            this.mnuFocusSelected.Click += new System.EventHandler(this.MnuFocusSelectedClick);
            // 
            // mnuLookAtSelected
            // 
            resources.ApplyResources(this.mnuLookAtSelected, "mnuLookAtSelected");
            this.mnuLookAtSelected.Name = "mnuLookAtSelected";
            this.mnuLookAtSelected.Click += new System.EventHandler(this.MnuLookAtSelectedClick);
            // 
            // mnuTrackSelected
            // 
            resources.ApplyResources(this.mnuTrackSelected, "mnuTrackSelected");
            this.mnuTrackSelected.Name = "mnuTrackSelected";
            this.mnuTrackSelected.Click += new System.EventHandler(this.MnuTrackSelectedClick);
            // 
            // mnuFocusSelectedSeperator
            // 
            this.mnuFocusSelectedSeperator.Name = "mnuFocusSelectedSeperator";
            resources.ApplyResources(this.mnuFocusSelectedSeperator, "mnuFocusSelectedSeperator");
            // 
            // mnuManipulationNone
            // 
            this.mnuManipulationNone.Checked = true;
            this.mnuManipulationNone.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.mnuManipulationNone, "mnuManipulationNone");
            this.mnuManipulationNone.Name = "mnuManipulationNone";
            this.mnuManipulationNone.Click += new System.EventHandler(this.MnuManipulationNoneClick);
            // 
            // mnuManipulationTranslate
            // 
            resources.ApplyResources(this.mnuManipulationTranslate, "mnuManipulationTranslate");
            this.mnuManipulationTranslate.Name = "mnuManipulationTranslate";
            this.mnuManipulationTranslate.Click += new System.EventHandler(this.MnuManipulationTranslateClick);
            // 
            // mnuManipulationRotate
            // 
            resources.ApplyResources(this.mnuManipulationRotate, "mnuManipulationRotate");
            this.mnuManipulationRotate.Name = "mnuManipulationRotate";
            this.mnuManipulationRotate.Click += new System.EventHandler(this.MnuManipulationRotateClick);
            // 
            // mnuManipulationScale
            // 
            resources.ApplyResources(this.mnuManipulationScale, "mnuManipulationScale");
            this.mnuManipulationScale.Name = "mnuManipulationScale";
            this.mnuManipulationScale.Click += new System.EventHandler(this.MnuManipulationScaleClick);
            // 
            // mnuManipulationSeperator
            // 
            this.mnuManipulationSeperator.Name = "mnuManipulationSeperator";
            resources.ApplyResources(this.mnuManipulationSeperator, "mnuManipulationSeperator");
            // 
            // mnuShowModels
            // 
            resources.ApplyResources(this.mnuShowModels, "mnuShowModels");
            this.mnuShowModels.Name = "mnuShowModels";
            this.mnuShowModels.Click += new System.EventHandler(this.MnuShowModelsClick);
            // 
            // mnuChangeVisibility
            // 
            resources.ApplyResources(this.mnuChangeVisibility, "mnuChangeVisibility");
            this.mnuChangeVisibility.Name = "mnuChangeVisibility";
            this.mnuChangeVisibility.Click += new System.EventHandler(this.MnuChangeVisibilityClick);
            // 
            // mnuShowModelsSeperator
            // 
            this.mnuShowModelsSeperator.Name = "mnuShowModelsSeperator";
            resources.ApplyResources(this.mnuShowModelsSeperator, "mnuShowModelsSeperator");
            // 
            // mnuFullScreen
            // 
            this.mnuFullScreen.Image = global::FreelancerModStudio.Properties.Resources.FullScreen;
            this.mnuFullScreen.Name = "mnuFullScreen";
            resources.ApplyResources(this.mnuFullScreen, "mnuFullScreen");
            this.mnuFullScreen.Click += new System.EventHandler(this.MnuFullScreenClick);
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuTools.MergeIndex = 3;
            this.mnuTools.Name = "mnuTools";
            resources.ApplyResources(this.mnuTools, "mnuTools");
            // 
            // mnuOptions
            // 
            this.mnuOptions.Image = global::FreelancerModStudio.Properties.Resources.Settings;
            this.mnuOptions.Name = "mnuOptions";
            resources.ApplyResources(this.mnuOptions, "mnuOptions");
            this.mnuOptions.Click += new System.EventHandler(this.MnuOptionsClick);
            // 
            // mnuWindows
            // 
            this.mnuWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewWindow,
            this.toolStripMenuItem1,
            this.mnuCloseAllDocuments,
            this.mnuResetLayout,
            this.mnuWindowsSeperator});
            this.mnuWindows.MergeIndex = 4;
            this.mnuWindows.Name = "mnuWindows";
            resources.ApplyResources(this.mnuWindows, "mnuWindows");
            // 
            // mnuNewWindow
            // 
            resources.ApplyResources(this.mnuNewWindow, "mnuNewWindow");
            this.mnuNewWindow.Image = global::FreelancerModStudio.Properties.Resources.NewWindow;
            this.mnuNewWindow.Name = "mnuNewWindow";
            this.mnuNewWindow.Click += new System.EventHandler(this.MnuNewWindowClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // mnuCloseAllDocuments
            // 
            resources.ApplyResources(this.mnuCloseAllDocuments, "mnuCloseAllDocuments");
            this.mnuCloseAllDocuments.Image = global::FreelancerModStudio.Properties.Resources.Close;
            this.mnuCloseAllDocuments.Name = "mnuCloseAllDocuments";
            this.mnuCloseAllDocuments.Click += new System.EventHandler(this.MnuCloseAllDocumentsClick);
            // 
            // mnuResetLayout
            // 
            resources.ApplyResources(this.mnuResetLayout, "mnuResetLayout");
            this.mnuResetLayout.Name = "mnuResetLayout";
            // 
            // mnuWindowsSeperator
            // 
            this.mnuWindowsSeperator.Name = "mnuWindowsSeperator";
            resources.ApplyResources(this.mnuWindowsSeperator, "mnuWindowsSeperator");
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportIssue,
            this.mnuVisitForum,
            this.toolStripMenuItem2,
            this.mnuCheckUpdate,
            this.toolStripMenuItem10,
            this.mnuAbout});
            this.mnuHelp.MergeIndex = 5;
            this.mnuHelp.Name = "mnuHelp";
            resources.ApplyResources(this.mnuHelp, "mnuHelp");
            // 
            // mnuReportIssue
            // 
            this.mnuReportIssue.Image = global::FreelancerModStudio.Properties.Resources.ReportIssue;
            this.mnuReportIssue.Name = "mnuReportIssue";
            resources.ApplyResources(this.mnuReportIssue, "mnuReportIssue");
            this.mnuReportIssue.Click += new System.EventHandler(this.MnuReportIssueClick);
            // 
            // mnuVisitForum
            // 
            this.mnuVisitForum.Image = global::FreelancerModStudio.Properties.Resources.HomePage;
            this.mnuVisitForum.Name = "mnuVisitForum";
            resources.ApplyResources(this.mnuVisitForum, "mnuVisitForum");
            this.mnuVisitForum.Click += new System.EventHandler(this.MnuVisitForumClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // mnuCheckUpdate
            // 
            this.mnuCheckUpdate.Image = global::FreelancerModStudio.Properties.Resources.WebSearch;
            this.mnuCheckUpdate.Name = "mnuCheckUpdate";
            resources.ApplyResources(this.mnuCheckUpdate, "mnuCheckUpdate");
            this.mnuCheckUpdate.Click += new System.EventHandler(this.MnuCheckUpdateClick);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            resources.ApplyResources(this.toolStripMenuItem10, "toolStripMenuItem10");
            // 
            // mnuAbout
            // 
            this.mnuAbout.Image = global::FreelancerModStudio.Properties.Resources.About;
            this.mnuAbout.Name = "mnuAbout";
            resources.ApplyResources(this.mnuAbout, "mnuAbout");
            this.mnuAbout.Click += new System.EventHandler(this.MnuAboutClick);
            // 
            // toolStripPanel3
            // 
            resources.ApplyResources(this.toolStripPanel3, "toolStripPanel3");
            this.toolStripPanel3.Name = "toolStripPanel3";
            this.toolStripPanel3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.toolStripPanel3.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            // 
            // dockPanel1
            // 
            resources.ApplyResources(this.dockPanel1, "dockPanel1");
            this.dockPanel1.DockBackColor = System.Drawing.SystemColors.Control;
            this.dockPanel1.DockBottomPortion = 150D;
            this.dockPanel1.DockLeftPortion = 200D;
            this.dockPanel1.DockRightPortion = 200D;
            this.dockPanel1.DockTopPortion = 150D;
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.ContentRemoved += new System.EventHandler<WeifenLuo.WinFormsUI.Docking.DockContentEventArgs>(this.DockPanel1ContentRemoved);
            this.dockPanel1.ActiveDocumentChanged += new System.EventHandler(this.DockPanel1ActiveDocumentChanged);
            this.dockPanel1.ActiveContentChanged += new System.EventHandler(this.DockPanel1ActiveContentChanged);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            // 
            // toolStripPanel4
            // 
            resources.ApplyResources(this.toolStripPanel4, "toolStripPanel4");
            this.toolStripPanel4.Name = "toolStripPanel4";
            this.toolStripPanel4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripPanel4.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClose2,
            this.mnuCloseOther,
            this.MnuCloseAllUnchanged,
            this.MnuCloseAllToLeft,
            this.MnuCloseAllToRight,
            this.mnuCopyFullPathSeperator,
            this.mnuCopyFullPath,
            this.mnuOpenContainingFolder});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1Opening);
            // 
            // mnuClose2
            // 
            this.mnuClose2.Name = "mnuClose2";
            resources.ApplyResources(this.mnuClose2, "mnuClose2");
            this.mnuClose2.Click += new System.EventHandler(this.MnuCloseClick);
            // 
            // mnuCloseOther
            // 
            this.mnuCloseOther.Name = "mnuCloseOther";
            resources.ApplyResources(this.mnuCloseOther, "mnuCloseOther");
            this.mnuCloseOther.Click += new System.EventHandler(this.MnuCloseOtherClick);
            // 
            // MnuCloseAllUnchanged
            // 
            this.MnuCloseAllUnchanged.Name = "MnuCloseAllUnchanged";
            resources.ApplyResources(this.MnuCloseAllUnchanged, "MnuCloseAllUnchanged");
            this.MnuCloseAllUnchanged.Click += new System.EventHandler(this.MnuCloseAllUnchanged_Click);
            // 
            // MnuCloseAllToLeft
            // 
            this.MnuCloseAllToLeft.Name = "MnuCloseAllToLeft";
            resources.ApplyResources(this.MnuCloseAllToLeft, "MnuCloseAllToLeft");
            this.MnuCloseAllToLeft.Click += new System.EventHandler(this.MnuCloseAllToLeft_Click);
            // 
            // MnuCloseAllToRight
            // 
            this.MnuCloseAllToRight.Name = "MnuCloseAllToRight";
            resources.ApplyResources(this.MnuCloseAllToRight, "MnuCloseAllToRight");
            this.MnuCloseAllToRight.Click += new System.EventHandler(this.MnuCloseAllToRight_Click);
            // 
            // mnuCopyFullPathSeperator
            // 
            this.mnuCopyFullPathSeperator.Name = "mnuCopyFullPathSeperator";
            resources.ApplyResources(this.mnuCopyFullPathSeperator, "mnuCopyFullPathSeperator");
            // 
            // mnuCopyFullPath
            // 
            resources.ApplyResources(this.mnuCopyFullPath, "mnuCopyFullPath");
            this.mnuCopyFullPath.Name = "mnuCopyFullPath";
            this.mnuCopyFullPath.Click += new System.EventHandler(this.MnuCopyFullPathClick);
            // 
            // mnuOpenContainingFolder
            // 
            resources.ApplyResources(this.mnuOpenContainingFolder, "mnuOpenContainingFolder");
            this.mnuOpenContainingFolder.Name = "mnuOpenContainingFolder";
            this.mnuOpenContainingFolder.Click += new System.EventHandler(this.MnuOpenContainingFolderClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // mnuRefresh
            // 
            this.mnuRefresh.Name = "mnuRefresh";
            resources.ApplyResources(this.mnuRefresh, "mnuRefresh");
            this.mnuRefresh.Click += new System.EventHandler(this.mnuRefresh_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.toolStripPanel4);
            this.Controls.Add(this.toolStripPanel2);
            this.Controls.Add(this.toolStripPanel3);
            this.Controls.Add(this.toolStripPanel1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainFormClosing);
            this.Load += new System.EventHandler(this.FrmMainLoad);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmMainDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmMainDragEnter);
            this.toolStripPanel2.ResumeLayout(false);
            this.toolStripPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStripPanel toolStripPanel1;
        private ToolStripPanel toolStripPanel2;
        private ToolStripPanel toolStripPanel3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuReportIssue;
        private ToolStripMenuItem mnuVisitForum;
        private ToolStripMenuItem mnuAbout;
        private DockPanel dockPanel1;
        private ToolStripMenuItem mnuWindows;
        private ToolStripMenuItem mnuCloseAllDocuments;
        private ToolStripMenuItem mnuNewWindow;
        private ToolStripSeparator mnuWindowsSeperator;
        private ToolStripSeparator mnuRecentFilesSeperator;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuOpen;
        private ToolStripMenuItem mnuOpenMod;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuTools;
        private ToolStripMenuItem mnuOptions;
        private ToolStripMenuItem mnuView;
        private ToolStripMenuItem mnuFullScreen;
        private ToolStripMenuItem mnuCloseMod;
        private ToolStripMenuItem mnuSaveAll;
        private ToolStripMenuItem mnuResetLayout;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripSeparator mnuSaveSeperator;
        private ToolStripSeparator toolStripMenuItem8;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator mnuCloseSeperator;
        private ToolStripMenuItem mnuCheckUpdate;
        private ToolStripSeparator toolStripMenuItem10;
        private ToolStripMenuItem mnuOpenFile;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem mnuNewMod;
        private ToolStripMenuItem mnuNewFile;
        private ToolStripMenuItem mnuSolutionExplorer;
        private ToolStripMenuItem mnuProperties;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem mnuEdit;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mnuUndo;
        private ToolStripMenuItem mnuRedo;
        private ToolStripMenuItem mnuAdd;
        private ToolStripMenuItem mnuDelete;
        private ToolStripMenuItem mnuSelectAll;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem mnuGoTo;
        private ToolStripMenuItem mnuClose;
        private ToolStripMenuItem mnuSave;
        private ToolStripMenuItem mnuSaveAs;
        private ToolStripPanel toolStripPanel4;
        private ToolStripMenuItem mnuCut;
        private ToolStripMenuItem mnuCopy;
        private ToolStripMenuItem mnuPaste;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem mnu3dEditor;
        private ToolStripSeparator mnuFocusSelectedSeperator;
        private ToolStripMenuItem mnuFocusSelected;
        private ToolStripMenuItem mnuShowModels;
        private ToolStripSeparator mnuShowModelsSeperator;
        private ToolStripMenuItem mnuChangeVisibility;
        private ToolStripMenuItem mnuTrackSelected;
        private ToolStripMenuItem mnuManipulationNone;
        private ToolStripMenuItem mnuManipulationTranslate;
        private ToolStripMenuItem mnuManipulationRotate;
        private ToolStripMenuItem mnuManipulationScale;
        private ToolStripSeparator mnuManipulationSeperator;
        private ToolStripMenuItem mnuLookAtSelected;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mnuClose2;
        private ToolStripMenuItem mnuCloseOther;
        private ToolStripSeparator mnuCopyFullPathSeperator;
        private ToolStripMenuItem mnuOpenContainingFolder;
        private ToolStripMenuItem mnuCopyFullPath;
        private ToolStripMenuItem MnuCloseAllToLeft;
        private ToolStripMenuItem MnuCloseAllToRight;
        private ToolStripMenuItem MnuCloseAllUnchanged;
        private ToolStripMenuItem mnuRefresh;
        private ToolStripSeparator toolStripSeparator1;
    }
}

