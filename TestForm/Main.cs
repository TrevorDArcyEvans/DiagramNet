namespace TestForm;

using Dalssoft.TestForm;
using DiagramNet;

/// <summary>
/// Summary description for Form1.
/// </summary>
public class Form1 : System.Windows.Forms.Form
{
  private bool changeDocumentProp = true;

  private System.Windows.Forms.ToolStrip toolBar1;
  private System.Windows.Forms.ToolStripButton btnSize;
  private System.Windows.Forms.ToolStripDropDownButton btnAdd;
  private System.Windows.Forms.ToolStripButton btnDelete;
  private System.Windows.Forms.ToolStripDropDownButton btnConnect;
  private System.Windows.Forms.ImageList imageList1;
  private System.Windows.Forms.ContextMenuStrip contextMenu1;
  private System.Windows.Forms.ToolStripSeparator sep1;
  private System.Windows.Forms.ToolStripButton btnSave;
  private System.Windows.Forms.ToolStripButton btnOpen;
  private System.Windows.Forms.ToolStripSeparator sep2;
  private System.Windows.Forms.ToolStripButton btnUndo;
  private System.Windows.Forms.ToolStripButton btnRedo;
  private System.Windows.Forms.ToolStripSeparator sep3;
  private System.Windows.Forms.ToolStripButton btnFront;
  private System.Windows.Forms.ToolStripButton btnBack;
  private System.Windows.Forms.ToolStripButton btnMoveUp;
  private System.Windows.Forms.ToolStripButton btnMoveDown;
  private System.Windows.Forms.MenuStrip mainMenu1;
  private System.Windows.Forms.ToolStripMenuItem menuItem11;
  private System.Windows.Forms.ToolStripMenuItem menuItem20;
  private System.Windows.Forms.ToolStripMenuItem menuItem26;
  private System.Windows.Forms.Panel panel1;
  private System.Windows.Forms.PropertyGrid propertyGrid1;
  private System.Windows.Forms.Splitter splitter1;
  private System.Windows.Forms.ToolStripMenuItem mnuFile;
  private System.Windows.Forms.ToolStripMenuItem mnuOpen;
  private System.Windows.Forms.ToolStripMenuItem mnuSave;
  private System.Windows.Forms.ToolStripMenuItem mnuExit;
  private System.Windows.Forms.ToolStripMenuItem mnuEdit;
  private System.Windows.Forms.ToolStripMenuItem mnuRedo;
  private System.Windows.Forms.ToolStripMenuItem mnuAdd;
  private System.Windows.Forms.ToolStripMenuItem mnuRectangle;
  private System.Windows.Forms.ToolStripMenuItem mnuEllipse;
  private System.Windows.Forms.ToolStripMenuItem mnuRectangleNode;
  private System.Windows.Forms.ToolStripMenuItem mnuEllipseNode;
  private System.Windows.Forms.ToolStripMenuItem mnuDelete;
  private System.Windows.Forms.ToolStripMenuItem mnuConnect;
  private System.Windows.Forms.ToolStripMenuItem mnuOrder;
  private System.Windows.Forms.ToolStripMenuItem mnuBringToFront;
  private System.Windows.Forms.ToolStripMenuItem mnuSendToBack;
  private System.Windows.Forms.ToolStripMenuItem mnuMoveUp;
  private System.Windows.Forms.ToolStripMenuItem mnuMoveDown;
  private System.Windows.Forms.ToolStripMenuItem mnuHelp;
  private System.Windows.Forms.ToolStripMenuItem mnuAbout;
  private System.Windows.Forms.ToolStripMenuItem mnuSize;
  private System.Windows.Forms.ToolStripMenuItem mnuTbRectangle;
  private System.Windows.Forms.ToolStripMenuItem mnuTbEllipse;
  private System.Windows.Forms.ToolStripMenuItem mnuTbRectangleNode;
  private System.Windows.Forms.ToolStripMenuItem mnuTbEllipseNode;
  private System.Windows.Forms.OpenFileDialog openFileDialog1;
  private System.Windows.Forms.SaveFileDialog saveFileDialog1;
  private System.Windows.Forms.ToolStripMenuItem mnuUndo;
  private System.Windows.Forms.ContextMenuStrip contextMenu2;
  private System.Windows.Forms.ToolStripMenuItem mnuTbStraightLink;
  private System.Windows.Forms.ToolStripMenuItem mnuTbRightAngleLink;
  private System.Windows.Forms.ToolStripMenuItem menuItem3;
  private System.Windows.Forms.ToolStripMenuItem mnuCut;
  private System.Windows.Forms.ToolStripMenuItem mnuPaste;
  private System.Windows.Forms.ToolStripMenuItem mnuCopy;
  private System.Windows.Forms.ToolStripSeparator sep4;
  private System.Windows.Forms.ToolStripButton btnCut;
  private System.Windows.Forms.ToolStripButton btnCopy;
  private System.Windows.Forms.ToolStripButton btnPaste;
  private System.Windows.Forms.ToolStripSeparator sep5;
  private System.Windows.Forms.ToolStripDropDownButton btnZoom;
  private System.Windows.Forms.ContextMenuStrip contextMenu_Zoom;
  private System.Windows.Forms.ToolStripMenuItem mnuZoom_10;
  private System.Windows.Forms.ToolStripMenuItem mnuZoom_25;
  private System.Windows.Forms.ToolStripMenuItem mnuZoom_50;
  private System.Windows.Forms.ToolStripMenuItem mnuZoom_75;
  private System.Windows.Forms.ToolStripMenuItem mnuZoom_100;
  private System.Windows.Forms.ToolStripMenuItem mnuZoom_150;
  private System.Windows.Forms.ToolStripMenuItem mnuZoom_200;
  private System.Windows.Forms.Splitter splitter2;
  private System.Windows.Forms.TextBox txtLog;
  private System.Windows.Forms.ToolStripMenuItem mnuShowDebugLog;
  private System.Windows.Forms.ToolStripMenuItem menuItem1;
  private DiagramNet.Designer designer1;
  private System.Windows.Forms.ToolStripMenuItem TbCommentBox;
  private ToolStripMenuItem menuSaveas;
  private ToolStripMenuItem TbCommentBoxNode;
  private ToolStripMenuItem TbDiagramBlockNode;
  private System.ComponentModel.IContainer components;

  public Form1()
  {

    //
    // Required for Windows Form Designer support
    //
    InitializeComponent();

    //
    // TODO: Add any constructor code after InitializeComponent call
    //
  }

  /// <summary>
  /// Clean up any resources being used.
  /// </summary>
  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (components != null)
      {
        components.Dispose();
      }
    }
    base.Dispose(disposing);
  }

  #region Windows Form Designer generated code
  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
    this.toolBar1 = new System.Windows.Forms.ToolStrip();
    this.btnOpen = new System.Windows.Forms.ToolStripButton();
    this.btnSave = new System.Windows.Forms.ToolStripButton();
    this.sep1 = new System.Windows.Forms.ToolStripSeparator();
    this.btnCut = new System.Windows.Forms.ToolStripButton();
    this.btnCopy = new System.Windows.Forms.ToolStripButton();
    this.btnPaste = new System.Windows.Forms.ToolStripButton();
    this.btnDelete = new System.Windows.Forms.ToolStripButton();
    this.sep4 = new System.Windows.Forms.ToolStripSeparator();
    this.btnSize = new System.Windows.Forms.ToolStripButton();
    this.btnAdd = new System.Windows.Forms.ToolStripDropDownButton();
    this.contextMenu1 = new System.Windows.Forms.ContextMenuStrip();
    this.mnuTbRectangle = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuTbEllipse = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuTbRectangleNode = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuTbEllipseNode = new System.Windows.Forms.ToolStripMenuItem();
    this.TbCommentBox = new System.Windows.Forms.ToolStripMenuItem();
    this.btnConnect = new System.Windows.Forms.ToolStripDropDownButton();
    this.contextMenu2 = new System.Windows.Forms.ContextMenuStrip();
    this.mnuTbStraightLink = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuTbRightAngleLink = new System.Windows.Forms.ToolStripMenuItem();
    this.sep2 = new System.Windows.Forms.ToolStripSeparator();
    this.btnUndo = new System.Windows.Forms.ToolStripButton();
    this.btnRedo = new System.Windows.Forms.ToolStripButton();
    this.sep3 = new System.Windows.Forms.ToolStripSeparator();
    this.btnZoom = new System.Windows.Forms.ToolStripDropDownButton();
    this.contextMenu_Zoom = new System.Windows.Forms.ContextMenuStrip();
    this.mnuZoom_10 = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuZoom_25 = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuZoom_50 = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuZoom_75 = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuZoom_100 = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuZoom_150 = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuZoom_200 = new System.Windows.Forms.ToolStripMenuItem();
    this.sep5 = new System.Windows.Forms.ToolStripSeparator();
    this.btnFront = new System.Windows.Forms.ToolStripButton();
    this.btnBack = new System.Windows.Forms.ToolStripButton();
    this.btnMoveUp = new System.Windows.Forms.ToolStripButton();
    this.btnMoveDown = new System.Windows.Forms.ToolStripButton();
    this.imageList1 = new System.Windows.Forms.ImageList();
    this.mainMenu1 = new System.Windows.Forms.MenuStrip();
    this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
    this.menuSaveas = new System.Windows.Forms.ToolStripMenuItem();
    this.menuItem26 = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuRedo = new System.Windows.Forms.ToolStripMenuItem();
    this.menuItem3 = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
    this.menuItem11 = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuSize = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuRectangle = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuEllipse = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuRectangleNode = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuEllipseNode = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuConnect = new System.Windows.Forms.ToolStripMenuItem();
    this.menuItem20 = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuOrder = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuBringToFront = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuSendToBack = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuMoveUp = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuMoveDown = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuShowDebugLog = new System.Windows.Forms.ToolStripMenuItem();
    this.menuItem1 = new System.Windows.Forms.ToolStripMenuItem();
    this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
    this.panel1 = new System.Windows.Forms.Panel();
    this.designer1 = new DiagramNet.Designer(this.components);
    this.splitter2 = new System.Windows.Forms.Splitter();
    this.txtLog = new System.Windows.Forms.TextBox();
    this.splitter1 = new System.Windows.Forms.Splitter();
    this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
    this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
    this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
    this.TbCommentBoxNode = new System.Windows.Forms.ToolStripMenuItem();
    this.TbDiagramBlockNode = new System.Windows.Forms.ToolStripMenuItem();
    this.panel1.SuspendLayout();
    this.SuspendLayout();
    // 
    // toolBar1
    // 
    this.toolBar1.AllowDrop = true;
    // TODO   this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
    this.toolBar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
      this.btnOpen,
      this.btnSave,
      this.sep1,
      this.btnCut,
      this.btnCopy,
      this.btnPaste,
      this.btnDelete,
      this.sep4,
      this.btnSize,
      this.btnAdd,
      this.btnConnect,
      this.sep2,
      this.btnUndo,
      this.btnRedo,
      this.sep3,
      this.btnZoom,
      this.sep5,
      this.btnFront,
      this.btnBack,
      this.btnMoveUp,
      this.btnMoveDown});
    // TODO   this.toolBar1.Divider = false;
    // TODO   this.toolBar1.DropDownArrows = true;
    this.toolBar1.ImageList = this.imageList1;
    this.toolBar1.Location = new System.Drawing.Point(0, 0);
    this.toolBar1.Name = "toolBar1";
    // TODO   this.toolBar1.ShowToolTips = true;
    this.toolBar1.Size = new System.Drawing.Size(696, 26);
    this.toolBar1.TabIndex = 1;
    // TODO   this.toolBar1.Wrappable = false;
    this.toolBar1.ItemClicked += this.toolBar1_ButtonClick;
    // 
    // btnOpen
    // 
    this.btnOpen.ImageIndex = 6;
    this.btnOpen.Name = "btnOpen";
    this.btnOpen.Tag = "Open";
    this.btnOpen.ToolTipText = "Open";
    // 
    // btnSave
    // 
    this.btnSave.ImageIndex = 5;
    this.btnSave.Name = "btnSave";
    this.btnSave.Tag = "Save";
    this.btnSave.ToolTipText = "Save";
    // 
    // sep1
    // 
    this.sep1.Name = "sep1";
    //this.sep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
    // 
    // btnCut
    // 
    this.btnCut.ImageIndex = 13;
    this.btnCut.Name = "btnCut";
    this.btnCut.Tag = "Cut";
    this.btnCut.ToolTipText = "Cut";
    // 
    // btnCopy
    // 
    this.btnCopy.ImageIndex = 14;
    this.btnCopy.Name = "btnCopy";
    this.btnCopy.Tag = "Copy";
    this.btnCopy.ToolTipText = "Copy";
    // 
    // btnPaste
    // 
    this.btnPaste.ImageIndex = 15;
    this.btnPaste.Name = "btnPaste";
    this.btnPaste.Tag = "Paste";
    this.btnPaste.ToolTipText = "Paste";
    // 
    // btnDelete
    // 
    this.btnDelete.ImageIndex = 2;
    this.btnDelete.Name = "btnDelete";
    // TODO   this.btnDelete.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
    this.btnDelete.Tag = "Delete";
    this.btnDelete.ToolTipText = "Delete";
    // 
    // sep4
    // 
    this.sep4.Name = "sep4";
    //this.sep4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
    // 
    // btnSize
    // 
    this.btnSize.ImageIndex = 0;
    this.btnSize.Name = "btnSize";
    // TODO   this.btnSize.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
    this.btnSize.Tag = "Size";
    this.btnSize.ToolTipText = "Size";
    // 
    // btnAdd
    // 
    this.btnAdd.DropDown = this.contextMenu1;
    this.btnAdd.ImageIndex = 1;
    this.btnAdd.Name = "btnAdd";
    // TODO   this.btnAdd.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
    this.btnAdd.Tag = "Add";
    this.btnAdd.ToolTipText = "Add";
    // 
    // contextMenu1
    // 
    this.contextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
      this.mnuTbRectangle,
      this.mnuTbEllipse,
      this.mnuTbRectangleNode,
      this.mnuTbEllipseNode,
      this.TbCommentBox,
      this.TbCommentBoxNode,
      this.TbDiagramBlockNode
    });
    // 
    // mnuTbRectangle
    // 
    this.mnuTbRectangle.Text = "&Rectangle";
    this.mnuTbRectangle.Click += new System.EventHandler(this.mnuTbRectangle_Click);
    // 
    // mnuTbEllipse
    // 
    this.mnuTbEllipse.Text = "&Ellipse";
    this.mnuTbEllipse.Click += new System.EventHandler(this.mnuTbEllipse_Click);
    // 
    // mnuTbRectangleNode
    // 
    this.mnuTbRectangleNode.Text = "&Node Rectangle";
    this.mnuTbRectangleNode.Click += new System.EventHandler(this.mnuTbRectangleNode_Click);
    // 
    // mnuTbEllipseNode
    // 
    this.mnuTbEllipseNode.Text = "N&ode Ellipse";
    this.mnuTbEllipseNode.Click += new System.EventHandler(this.mnuTbEllipseNode_Click);
    // 
    // TbCommentBox
    // 
    this.TbCommentBox.Text = "Comment Box";
    this.TbCommentBox.Click += new System.EventHandler(this.TbCommentBox_Click);
    // 
    // btnConnect
    // 
    this.btnConnect.DropDown = this.contextMenu2;
    this.btnConnect.ImageIndex = 3;
    this.btnConnect.Name = "btnConnect";
    // TODO   this.btnConnect.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
    this.btnConnect.Tag = "Connect";
    this.btnConnect.ToolTipText = "Connect";
    // 
    // contextMenu2
    // 
    this.contextMenu2.Items.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
      this.mnuTbStraightLink,
      this.mnuTbRightAngleLink});
    // 
    // mnuTbStraightLink
    // 
    this.mnuTbStraightLink.Text = "Straight Link";
    this.mnuTbStraightLink.Click += new System.EventHandler(this.mnuTbStraightLink_Click);
    // 
    // mnuTbRightAngleLink
    // 
    this.mnuTbRightAngleLink.Text = "Right Angle Link";
    this.mnuTbRightAngleLink.Click += new System.EventHandler(this.mnuTbRightAngleLink_Click);
    // 
    // sep2
    // 
    this.sep2.Name = "sep2";
    //this.sep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
    // 
    // btnUndo
    // 
    this.btnUndo.ImageIndex = 7;
    this.btnUndo.Name = "btnUndo";
    this.btnUndo.Tag = "Undo";
    this.btnUndo.ToolTipText = "Undo";
    // 
    // btnRedo
    // 
    this.btnRedo.ImageIndex = 8;
    this.btnRedo.Name = "btnRedo";
    this.btnRedo.Tag = "Redo";
    this.btnRedo.ToolTipText = "Redo";
    // 
    // sep3
    // 
    this.sep3.Name = "sep3";
    //this.sep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
    // 
    // btnZoom
    // 
    this.btnZoom.DropDown = this.contextMenu_Zoom;
    this.btnZoom.ImageIndex = 16;
    this.btnZoom.Name = "btnZoom";
    // TODO   this.btnZoom.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
    this.btnZoom.Tag = "Zoom";
    // 
    // contextMenu_Zoom
    // 
    this.contextMenu_Zoom.Items.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
      this.mnuZoom_10,
      this.mnuZoom_25,
      this.mnuZoom_50,
      this.mnuZoom_75,
      this.mnuZoom_100,
      this.mnuZoom_150,
      this.mnuZoom_200});
    // 
    // mnuZoom_10
    // 
    this.mnuZoom_10.Text = "10%";
    this.mnuZoom_10.Click += new System.EventHandler(this.mnuZoom_10_Click);
    // 
    // mnuZoom_25
    // 
    this.mnuZoom_25.Text = "25%";
    this.mnuZoom_25.Click += new System.EventHandler(this.mnuZoom_25_Click);
    // 
    // mnuZoom_50
    // 
    this.mnuZoom_50.Text = "50%";
    this.mnuZoom_50.Click += new System.EventHandler(this.mnuZoom_50_Click);
    // 
    // mnuZoom_75
    // 
    this.mnuZoom_75.Text = "75%";
    this.mnuZoom_75.Click += new System.EventHandler(this.mnuZoom_75_Click);
    // 
    // mnuZoom_100
    // 
    this.mnuZoom_100.Text = "100%";
    this.mnuZoom_100.Click += new System.EventHandler(this.mnuZoom_100_Click);
    // 
    // mnuZoom_150
    // 
    this.mnuZoom_150.Text = "150%";
    this.mnuZoom_150.Click += new System.EventHandler(this.mnuZoom_150_Click);
    // 
    // mnuZoom_200
    // 
    this.mnuZoom_200.Text = "200%";
    this.mnuZoom_200.Click += new System.EventHandler(this.mnuZoom_200_Click);
    // 
    // sep5
    // 
    this.sep5.Name = "sep5";
    //this.sep5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
    // 
    // btnFront
    // 
    this.btnFront.ImageIndex = 9;
    this.btnFront.Name = "btnFront";
    this.btnFront.Tag = "Front";
    this.btnFront.ToolTipText = "Bring to Front";
    // 
    // btnBack
    // 
    this.btnBack.ImageIndex = 10;
    this.btnBack.Name = "btnBack";
    this.btnBack.Tag = "Back";
    this.btnBack.ToolTipText = "Send to Back";
    // 
    // btnMoveUp
    // 
    this.btnMoveUp.ImageIndex = 11;
    this.btnMoveUp.Name = "btnMoveUp";
    this.btnMoveUp.Tag = "MoveUp";
    this.btnMoveUp.ToolTipText = "Move Up";
    // 
    // btnMoveDown
    // 
    this.btnMoveDown.ImageIndex = 12;
    this.btnMoveDown.Name = "btnMoveDown";
    this.btnMoveDown.Tag = "MoveDown";
    this.btnMoveDown.ToolTipText = "Move Down";
    // 
    // imageList1
    // 
    this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
    this.imageList1.TransparentColor = System.Drawing.Color.Silver;
    this.imageList1.Images.SetKeyName(0, "");
    this.imageList1.Images.SetKeyName(1, "");
    this.imageList1.Images.SetKeyName(2, "");
    this.imageList1.Images.SetKeyName(3, "");
    this.imageList1.Images.SetKeyName(4, "");
    this.imageList1.Images.SetKeyName(5, "");
    this.imageList1.Images.SetKeyName(6, "");
    this.imageList1.Images.SetKeyName(7, "");
    this.imageList1.Images.SetKeyName(8, "");
    this.imageList1.Images.SetKeyName(9, "");
    this.imageList1.Images.SetKeyName(10, "");
    this.imageList1.Images.SetKeyName(11, "");
    this.imageList1.Images.SetKeyName(12, "");
    this.imageList1.Images.SetKeyName(13, "");
    this.imageList1.Images.SetKeyName(14, "");
    this.imageList1.Images.SetKeyName(15, "");
    this.imageList1.Images.SetKeyName(16, "");
    // 
    // mainMenu1
    // 
    this.mainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
      this.mnuFile,
      this.mnuEdit,
      this.mnuHelp});
    // 
    // mnuFile
    // 
    this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
      this.mnuOpen,
      this.mnuSave,
      this.menuSaveas,
      this.menuItem26,
      this.mnuExit});
    this.mnuFile.Text = "&File";
    // 
    // mnuOpen
    // 
    this.mnuOpen.Text = "&Open";
    this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
    // 
    // mnuSave
    // 
    this.mnuSave.Text = "&Save";
    this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
    // 
    // menuSaveas
    // 
    this.menuSaveas.Text = "Save &as ";
    this.menuSaveas.Click += new System.EventHandler(this.menuSaveas_Click);
    // 
    // menuItem26
    // 
    this.menuItem26.Text = "-";
    // 
    // mnuExit
    // 
    this.mnuExit.Text = "&Exit";
    this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
    // 
    // mnuEdit
    // 
    this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
      this.mnuUndo,
      this.mnuRedo,
      this.menuItem3,
      this.mnuCut,
      this.mnuCopy,
      this.mnuPaste,
      this.mnuDelete,
      this.menuItem11,
      this.mnuSize,
      this.mnuAdd,
      this.mnuConnect,
      this.menuItem20,
      this.mnuOrder});
    this.mnuEdit.Text = "&Edit";
    // 
    // mnuUndo
    // 
    this.mnuUndo.Text = "&Undo";
    this.mnuUndo.Click += new System.EventHandler(this.mnuUndo_Click);
    // 
    // mnuRedo
    // 
    this.mnuRedo.Text = "&Redo";
    this.mnuRedo.Click += new System.EventHandler(this.mnuRedo_Click);
    // 
    // menuItem3
    // 
    this.menuItem3.Text = "-";
    // 
    // mnuCut
    // 
    this.mnuCut.Text = "Cu&t";
    this.mnuCut.Click += new System.EventHandler(this.mnuCut_Click);
    // 
    // mnuCopy
    // 
    this.mnuCopy.Text = "Cop&y";
    this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
    // 
    // mnuPaste
    // 
    this.mnuPaste.Text = "Paste";
    this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
    // 
    // mnuDelete
    // 
    this.mnuDelete.Text = "&Delete";
    this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
    // 
    // menuItem11
    // 
    this.menuItem11.Text = "-";
    // 
    // mnuSize
    // 
    this.mnuSize.Text = "&Size";
    this.mnuSize.Click += new System.EventHandler(this.mnuSize_Click);
    // 
    // mnuAdd
    // 
    this.mnuAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
      this.mnuRectangle,
      this.mnuEllipse,
      this.mnuRectangleNode,
      this.mnuEllipseNode});
    this.mnuAdd.Text = "&Add";
    // 
    // mnuRectangle
    // 
    this.mnuRectangle.Text = "&Rectangle";
    this.mnuRectangle.Click += new System.EventHandler(this.mnuRectangle_Click);
    // 
    // mnuEllipse
    // 
    this.mnuEllipse.Text = "&Ellipse";
    this.mnuEllipse.Click += new System.EventHandler(this.mnuEllipse_Click);
    // 
    // mnuRectangleNode
    // 
    this.mnuRectangleNode.Text = "&Node Rectangle";
    this.mnuRectangleNode.Click += new System.EventHandler(this.mnuRectangleNode_Click);
    // 
    // mnuEllipseNode
    // 
    this.mnuEllipseNode.Text = "N&ode Ellipse";
    this.mnuEllipseNode.Click += new System.EventHandler(this.mnuEllipseNode_Click);
    // 
    // mnuConnect
    // 
    this.mnuConnect.Text = "&Connect";
    this.mnuConnect.Click += new System.EventHandler(this.mnuConnect_Click);
    // 
    // menuItem20
    // 
    this.menuItem20.Text = "-";
    // 
    // mnuOrder
    // 
    this.mnuOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
      this.mnuBringToFront,
      this.mnuSendToBack,
      this.mnuMoveUp,
      this.mnuMoveDown});
    this.mnuOrder.Text = "&Order";
    // 
    // mnuBringToFront
    // 
    this.mnuBringToFront.Text = "&Bring to Front";
    this.mnuBringToFront.Click += new System.EventHandler(this.mnuBringToFront_Click);
    // 
    // mnuSendToBack
    // 
    this.mnuSendToBack.Text = "Send to &Back";
    this.mnuSendToBack.Click += new System.EventHandler(this.mnuSendToBack_Click);
    // 
    // mnuMoveUp
    // 
    this.mnuMoveUp.Text = "Move &Up";
    this.mnuMoveUp.Click += new System.EventHandler(this.mnuMoveUp_Click);
    // 
    // mnuMoveDown
    // 
    this.mnuMoveDown.Text = "Move &Down";
    this.mnuMoveDown.Click += new System.EventHandler(this.mnuMoveDown_Click);
    // 
    // mnuHelp
    // 
    this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
      this.mnuShowDebugLog,
      this.menuItem1,
      this.mnuAbout});
    this.mnuHelp.Text = "&Help";
    // 
    // mnuShowDebugLog
    // 
    this.mnuShowDebugLog.Text = "&Show Debug Log...";
    this.mnuShowDebugLog.Click += new System.EventHandler(this.mnuShowDebugLog_Click);
    // 
    // menuItem1
    // 
    this.menuItem1.Text = "-";
    // 
    // mnuAbout
    // 
    this.mnuAbout.Text = "&About...";
    this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
    // 
    // panel1
    // 
    this.panel1.Controls.Add(this.designer1);
    this.panel1.Controls.Add(this.splitter2);
    this.panel1.Controls.Add(this.txtLog);
    this.panel1.Controls.Add(this.splitter1);
    this.panel1.Controls.Add(this.propertyGrid1);
    this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
    this.panel1.Location = new System.Drawing.Point(0, 26);
    this.panel1.Name = "panel1";
    this.panel1.Size = new System.Drawing.Size(696, 359);
    this.panel1.TabIndex = 2;
    // 
    // designer1
    // 
    this.designer1.AutoScroll = true;
    this.designer1.AutoScrollMinSize = new System.Drawing.Size(100, 100);
    this.designer1.BackColor = System.Drawing.SystemColors.Window;
    this.designer1.Dock = System.Windows.Forms.DockStyle.Fill;
    this.designer1.Location = new System.Drawing.Point(0, 0);
    this.designer1.Name = "designer1";
    this.designer1.Size = new System.Drawing.Size(423, 243);
    this.designer1.TabIndex = 6;
    this.designer1.ElementClick += new DiagramNet.Designer.ElementEventHandler(this.designer1_ElementClick);
    this.designer1.ElementMouseDown += new DiagramNet.Designer.ElementMouseEventHandler(this.designer1_ElementMouseDown);
    this.designer1.ElementMouseUp += new DiagramNet.Designer.ElementMouseEventHandler(this.designer1_ElementMouseUp);
    this.designer1.ElementMoving += new DiagramNet.Designer.ElementEventHandler(this.designer1_ElementMoving);
    this.designer1.ElementMoved += new DiagramNet.Designer.ElementEventHandler(this.designer1_ElementMoved);
    this.designer1.ElementResizing += new DiagramNet.Designer.ElementEventHandler(this.designer1_ElementResizing);
    this.designer1.ElementResized += new DiagramNet.Designer.ElementEventHandler(this.designer1_ElementResized);
    this.designer1.ElementConnecting += new DiagramNet.Designer.ElementConnectEventHandler(this.designer1_ElementConnecting);
    this.designer1.ElementConnected += new DiagramNet.Designer.ElementConnectEventHandler(this.designer1_ElementConnected);
    this.designer1.ElementSelection += new DiagramNet.Designer.ElementSelectionEventHandler(this.designer1_ElementSelection);
    this.designer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.designer1_MouseUp);
    // 
    // splitter2
    // 
    this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
    this.splitter2.Location = new System.Drawing.Point(0, 243);
    this.splitter2.Name = "splitter2";
    this.splitter2.Size = new System.Drawing.Size(423, 4);
    this.splitter2.TabIndex = 5;
    this.splitter2.TabStop = false;
    // 
    // txtLog
    // 
    this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
    this.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
    this.txtLog.Location = new System.Drawing.Point(0, 247);
    this.txtLog.Multiline = true;
    this.txtLog.Name = "txtLog";
    this.txtLog.ReadOnly = true;
    this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
    this.txtLog.Size = new System.Drawing.Size(423, 112);
    this.txtLog.TabIndex = 4;
    this.txtLog.Text = "Log:";
    this.txtLog.Visible = false;
    // 
    // splitter1
    // 
    this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
    this.splitter1.Location = new System.Drawing.Point(423, 0);
    this.splitter1.Name = "splitter1";
    this.splitter1.Size = new System.Drawing.Size(4, 359);
    this.splitter1.TabIndex = 1;
    this.splitter1.TabStop = false;
    // 
    // propertyGrid1
    // 
    this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
    this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
    this.propertyGrid1.Location = new System.Drawing.Point(427, 0);
    this.propertyGrid1.Name = "propertyGrid1";
    this.propertyGrid1.Size = new System.Drawing.Size(269, 359);
    this.propertyGrid1.TabIndex = 0;
    // 
    // openFileDialog1
    // 
    this.openFileDialog1.DefaultExt = "*.dgn";
    this.openFileDialog1.RestoreDirectory = true;
    // 
    // TbCommentBoxNode
    // 
    this.TbCommentBoxNode.Text = "Comment Box Node";
    this.TbCommentBoxNode.Click += new System.EventHandler(this.TbCommentBoxNode_Click);
    // 
    // TbDiagramBlockNode
    // 
    this.TbDiagramBlockNode.Text = "Diagram Block Node";
    this.TbDiagramBlockNode.Click += new System.EventHandler(this.TbDiagramBlockNode_Click);
    // 
    // Form1
    // 
    this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
    this.ClientSize = new System.Drawing.Size(696, 385);
    this.Controls.Add(this.panel1);
    this.Controls.Add(this.toolBar1);
    this.Controls.Add(this.mainMenu1);
    this.MainMenuStrip = this.mainMenu1;
    this.Name = "Form1";
    this.Text = "Diagram.NET Test Form";
    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
    this.Load += new System.EventHandler(this.Form1_Load);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
  #endregion

  /// <summary>
  /// The main entry point for the application.
  /// </summary>
  [STAThread]
  static void Main()
  {
    Application.EnableVisualStyles();
    Application.DoEvents();

    Application.Run(new Form1());
  }

  #region Functions
  private void Edit_UpdateUndoRedoEnable()
  {
    mnuUndo.Enabled = designer1.CanUndo;
    btnUndo.Enabled = designer1.CanUndo;
    mnuRedo.Enabled = designer1.CanRedo;
    btnRedo.Enabled = designer1.CanRedo;
  }

  private void Edit_Undo()
  {
    if (designer1.CanUndo)
      designer1.Undo();

    Edit_UpdateUndoRedoEnable();
  }

  private void Edit_Redo()
  {
    if (designer1.CanRedo)
      designer1.Redo();

    Edit_UpdateUndoRedoEnable();
  }

  private void Action_None()
  {
    mnuSize.Checked = false;
    mnuAdd.Checked = false;
    mnuDelete.Checked = false;
    mnuConnect.Checked = false;

    btnSize.CheckOnClick = false;
    // TODO   btnAdd.Pushed = false;
    btnDelete.CheckOnClick = false;
    // TODO   btnConnect.Pushed = false;

    mnuRectangle.Checked = false;
    mnuTbRectangle.Checked = false;
    mnuEllipse.Checked = false;
    mnuTbEllipse.Checked = false;
    mnuRectangleNode.Checked = false;
    mnuTbRectangleNode.Checked = false;
    mnuEllipseNode.Checked = false;
    mnuTbEllipseNode.Checked = false;
  }

  private void Action_Size()
  {
    Action_None();
    mnuSize.Checked = true;
    btnSize.CheckOnClick = true;
    if (changeDocumentProp)
      designer1.Document.Action = DesignerAction.Select;
  }

  private void Action_Add(ElementType e)
  {
    Action_None();
    // TODO   btnAdd.Pushed = true;
    switch (e)
    {
      case ElementType.Rectangle:
        mnuRectangle.Checked = true;
        mnuTbRectangle.Checked = true;
        break;
      case ElementType.Ellipse:
        mnuEllipse.Checked = true;
        mnuTbEllipse.Checked = true;
        break;
      case ElementType.RectangleNode:
        mnuRectangleNode.Checked = true;
        mnuTbRectangleNode.Checked = true;
        break;
      case ElementType.EllipseNode:
        mnuEllipseNode.Checked = true;
        mnuTbEllipseNode.Checked = true;
        break;
      case ElementType.DiagramBlock:
        break;
    }

    if (changeDocumentProp)
    {
      designer1.Document.Action = DesignerAction.Add;
      designer1.Document.ElementType = e;
    }
  }

  private void Action_Delete()
  {
    Action_None();
    mnuDelete.Checked = true;
    btnDelete.CheckOnClick = true;
    if (changeDocumentProp)
      designer1.Document.DeleteSelectedElements();
    Action_None();
  }

  private void Action_Connect()
  {
    Action_None();
    mnuConnect.Checked = true;
    // TODO   btnConnect.Pushed = true;
    if (changeDocumentProp)
      designer1.Document.Action = DesignerAction.Connect;
  }

  private void Action_Connector(LinkType lt)
  {
    Action_None();
    switch (lt)
    {
      case LinkType.Straight:
        mnuTbStraightLink.Checked = true;
        mnuTbRightAngleLink.Checked = false;
        break;
      case LinkType.RightAngle:
        mnuTbStraightLink.Checked = false;
        mnuTbRightAngleLink.Checked = true;
        break;
    }
    designer1.Document.LinkType = lt;
    Action_Connect();
  }

  private void Action_Zoom(float zoom)
  {
    designer1.Document.Zoom = zoom;
  }
  public string FileName { get; set; }
  private void File_Open()
  {
    openFileDialog1.FileName = FileName;
    openFileDialog1.Filter = "Diagram.Net files (*.dgn)|*.dgn|All files (*.*)|*.*";
    openFileDialog1.DefaultExt = ".dgn";
    if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
    {
      FileName = openFileDialog1.FileName;

      designer1.OpenBinary(openFileDialog1.FileName);
    }
  }

  private void File_Save()
  {
    if (File.Exists(FileName))
    {
      designer1.SaveBinary(FileName);
      Bitmap bmp = new Bitmap(designer1.Width, designer1.Height);
      designer1.DrawToBitmap(bmp, new Rectangle(0, 0, designer1.Width, designer1.Height));
      bmp.Save(FileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
    }
    else
    {
      File_SaveAs();
    }
  }

  private void File_SaveAs()
  {
    saveFileDialog1.FileName = FileName;
    saveFileDialog1.Filter = "Diagram.Net files (*.dgn)|*.dgn|All files (*.*)|*.*";
    saveFileDialog1.DefaultExt = ".dgn";
    if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
    {
      FileName = saveFileDialog1.FileName;
      designer1.SaveBinary(saveFileDialog1.FileName);
      Bitmap bmp = new Bitmap(designer1.Width, designer1.Height);
      designer1.DrawToBitmap(bmp, new Rectangle(0, 0, designer1.Width, designer1.Height));
      bmp.Save(saveFileDialog1.FileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
    }
  }

  private void Order_BringToFront()
  {
    if (designer1.Document.SelectedElements.Count == 1)
    {
      designer1.Document.BringToFrontElement(designer1.Document.SelectedElements[0]);
      designer1.Refresh();
    }
  }

  private void Order_SendToBack()
  {
    if (designer1.Document.SelectedElements.Count == 1)
    {
      designer1.Document.SendToBackElement(designer1.Document.SelectedElements[0]);
      designer1.Refresh();
    }
  }

  private void Order_MoveUp()
  {
    if (designer1.Document.SelectedElements.Count == 1)
    {
      designer1.Document.MoveUpElement(designer1.Document.SelectedElements[0]);
      designer1.Refresh();
    }
  }

  private void Order_MoveDown()
  {
    if (designer1.Document.SelectedElements.Count == 1)
    {
      designer1.Document.MoveDownElement(designer1.Document.SelectedElements[0]);
      designer1.Refresh();
    }
  }

  private void Clipboard_Cut()
  {
    designer1.Cut();
  }

  private void Clipboard_Copy()
  {
    designer1.Copy();
  }

  private void Clipboard_Paste()
  {
    designer1.Paste();
  }

  #endregion

  #region Menu Events
  private void mnuUndo_Click(object sender, System.EventArgs e)
  {
    Edit_Undo();
  }

  private void mnuRedo_Click(object sender, System.EventArgs e)
  {
    Edit_Redo();
  }

  private void mnuSize_Click(object sender, System.EventArgs e)
  {
    Action_Size();
  }

  private void mnuRectangle_Click(object sender, System.EventArgs e)
  {
    Action_Add(ElementType.Rectangle);
  }

  private void mnuEllipse_Click(object sender, System.EventArgs e)
  {
    Action_Add(ElementType.Ellipse);
  }

  private void mnuRectangleNode_Click(object sender, System.EventArgs e)
  {
    Action_Add(ElementType.RectangleNode);
  }

  private void mnuEllipseNode_Click(object sender, System.EventArgs e)
  {
    Action_Add(ElementType.EllipseNode);
  }

  private void mnuDelete_Click(object sender, System.EventArgs e)
  {
    Action_Delete();
  }

  private void mnuCut_Click(object sender, System.EventArgs e)
  {
    Clipboard_Cut();
  }

  private void mnuCopy_Click(object sender, System.EventArgs e)
  {
    Clipboard_Copy();
  }

  private void mnuPaste_Click(object sender, System.EventArgs e)
  {
    Clipboard_Paste();
  }

  private void mnuConnect_Click(object sender, System.EventArgs e)
  {
    Action_Connect();
  }

  private void mnuBringToFront_Click(object sender, System.EventArgs e)
  {
    Order_BringToFront();
  }

  private void mnuSendToBack_Click(object sender, System.EventArgs e)
  {
    Order_SendToBack();
  }

  private void mnuMoveUp_Click(object sender, System.EventArgs e)
  {
    Order_MoveUp();
  }

  private void mnuMoveDown_Click(object sender, System.EventArgs e)
  {
    Order_MoveDown();
  }

  private void mnuOpen_Click(object sender, System.EventArgs e)
  {
    File_Open();
  }

  private void mnuSave_Click(object sender, System.EventArgs e)
  {
    File_Save();
  }

  private void mnuExit_Click(object sender, System.EventArgs e)
  {
    this.Close();
  }

  private void mnuAbout_Click(object sender, System.EventArgs e)
  {
    About about = new About();
    about.ShowDialog(this);
  }
  #endregion

  #region Toolbar Events
  private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
  {

    string btn = (string)e.ClickedItem.Tag;

    if (btn == "Open") File_Open();
    if (btn == "Save") File_Save();

    if (btn == "Size") Action_Size();
    //if (btn == "Add")
    if (btn == "Delete") Action_Delete();
    if (btn == "Connect") Action_Connect();

    if (btn == "Undo") Edit_Undo();
    if (btn == "Redo") Edit_Redo();

    if (btn == "Front") Order_BringToFront();
    if (btn == "Back") Order_SendToBack();
    if (btn == "MoveUp") Order_MoveUp();
    if (btn == "MoveDown") Order_MoveDown();

    if (btn == "Cut") Clipboard_Cut();
    if (btn == "Copy") Clipboard_Copy();
    if (btn == "Paste") Clipboard_Paste();
  }

  private void mnuTbRectangle_Click(object sender, System.EventArgs e)
  {
    Action_Add(ElementType.Rectangle);
  }

  private void mnuTbEllipse_Click(object sender, System.EventArgs e)
  {
    Action_Add(ElementType.Ellipse);
  }

  private void mnuTbRectangleNode_Click(object sender, System.EventArgs e)
  {
    Action_Add(ElementType.RectangleNode);
  }

  private void mnuTbEllipseNode_Click(object sender, System.EventArgs e)
  {
    Action_Add(ElementType.EllipseNode);
  }

  private void TbCommentBox_Click(object sender, System.EventArgs e)
  {
    Action_Add(ElementType.CommentBox);
  }

  private void mnuTbStraightLink_Click(object sender, System.EventArgs e)
  {
    Action_Connector(LinkType.Straight);
  }

  private void mnuTbRightAngleLink_Click(object sender, System.EventArgs e)
  {
    Action_Connector(LinkType.RightAngle);
  }

  #endregion

  private void Form1_Load(object sender, System.EventArgs e)
  {
    Edit_UpdateUndoRedoEnable();

    //Events
    designer1.Document.PropertyChanged += new EventHandler(Document_PropertyChanged);
  }

  private void Document_PropertyChanged(object sender, EventArgs e)
  {
    changeDocumentProp = false;

    Action_None();

    switch (designer1.Document.Action)
    {
      case DesignerAction.Select:
        Action_Size();
        break;
      case DesignerAction.Delete:
        Action_Delete();
        break;
      case DesignerAction.Connect:
        Action_Connect();
        break;
      case DesignerAction.Add:
        Action_Add(designer1.Document.ElementType);
        break;
    }

    Edit_UpdateUndoRedoEnable();

    changeDocumentProp = true;
  }

  private void mnuZoom_10_Click(object sender, System.EventArgs e)
  {
    Action_Zoom(0.1f);
  }

  private void mnuZoom_25_Click(object sender, System.EventArgs e)
  {
    Action_Zoom(0.25f);
  }

  private void mnuZoom_50_Click(object sender, System.EventArgs e)
  {
    Action_Zoom(0.5f);
  }

  private void mnuZoom_75_Click(object sender, System.EventArgs e)
  {
    Action_Zoom(0.75f);
  }

  private void mnuZoom_100_Click(object sender, System.EventArgs e)
  {
    Action_Zoom(1f);
  }

  private void mnuZoom_150_Click(object sender, System.EventArgs e)
  {
    Action_Zoom(1.5f);
  }

  private void mnuZoom_200_Click(object sender, System.EventArgs e)
  {
    Action_Zoom(2.0f);
  }

  private void mnuShowDebugLog_Click(object sender, System.EventArgs e)
  {
    mnuShowDebugLog.Checked = !mnuShowDebugLog.Checked;
    txtLog.Visible = mnuShowDebugLog.Checked;

  }

  #region Events Handling 
  private void designer1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
  {
    AppendLog("designer1_MouseUp: {0}", e.ToString());

    propertyGrid1.SelectedObject = null;

    if (designer1.Document.SelectedElements.Count == 1)
    {
      propertyGrid1.SelectedObject = designer1.Document.SelectedElements[0];
    }
    else if (designer1.Document.SelectedElements.Count > 1)
    {
      propertyGrid1.SelectedObjects = designer1.Document.SelectedElements.GetArray();
    }
    else if (designer1.Document.SelectedElements.Count == 0)
    {
      propertyGrid1.SelectedObject = designer1.Document;
    }
  }

  private void designer1_ElementClick(object sender, DiagramNet.Events.ElementEventArgs e)
  {
    AppendLog("designer1_ElementClick: {0}", e.ToString());
  }

  private void designer1_ElementMouseDown(object sender, DiagramNet.Events.ElementMouseEventArgs e)
  {
    AppendLog("designer1_ElementMouseDown: {0}", e.ToString());
  }

  private void designer1_ElementMouseUp(object sender, DiagramNet.Events.ElementMouseEventArgs e)
  {
    AppendLog("designer1_ElementMouseUp: {0}", e.ToString());
  }

  private void designer1_ElementMoved(object sender, DiagramNet.Events.ElementEventArgs e)
  {
    AppendLog("designer1_ElementMoved: {0}", e.ToString());
  }

  private void designer1_ElementMoving(object sender, DiagramNet.Events.ElementEventArgs e)
  {
    AppendLog("designer1_ElementMoving: {0}", e.ToString());
  }

  private void designer1_ElementResized(object sender, DiagramNet.Events.ElementEventArgs e)
  {
    AppendLog("designer1_ElementResized: {0}", e.ToString());
  }

  private void designer1_ElementResizing(object sender, DiagramNet.Events.ElementEventArgs e)
  {
    AppendLog("designer1_ElementResizing: {0}", e.ToString());
  }

  private void designer1_ElementConnected(object sender, DiagramNet.Events.ElementConnectEventArgs e)
  {
    AppendLog("designer1_ElementConnected: {0}", e.ToString());
  }

  private void designer1_ElementConnecting(object sender, DiagramNet.Events.ElementConnectEventArgs e)
  {
    AppendLog("designer1_ElementConnecting: {0}", e.ToString());
  }

  private void designer1_ElementSelection(object sender, DiagramNet.Events.ElementSelectionEventArgs e)
  {
    AppendLog("designer1_ElementSelection: {0}", e.ToString());
  }

  #endregion

  private void AppendLog(string log)
  {
    AppendLog(log, "");
  }

  private void AppendLog(string log, params object[] args)
  {
    if (mnuShowDebugLog.Checked)
      txtLog.AppendText(String.Format(log, args) + "\r\n");
  }

  private void menuSaveas_Click(object sender, EventArgs e)
  {
    File_SaveAs();
  }

  private void TbCommentBoxNode_Click(object sender, EventArgs e)
  {
    Action_Add(ElementType.CommentBox);
  }

  private void TbDiagramBlockNode_Click(object sender, EventArgs e)
  {
    Action_Add(ElementType.DiagramBlock);
  }
}