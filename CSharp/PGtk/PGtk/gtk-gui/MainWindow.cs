
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action openAction;
	private global::Gtk.Action Action;
	private global::Gtk.Action saveAction;
	private global::Gtk.Action saveAsAction1;
	private global::Gtk.VBox vBox;
	private global::Gtk.Label labelSaludo;
	private global::Gtk.HBox hbox5;
	private global::Gtk.Label label2;
	private global::Gtk.Entry entryNombre;
	private global::Gtk.Button buttonAceptar;
	private global::Gtk.Alignment alignment1;
	private global::Gtk.VBox vbox3;
	private global::Gtk.Toolbar toolbar1;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TextView text1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.openAction = new global::Gtk.Action ("openAction", null, null, "gtk-open");
		w1.Add (this.openAction, null);
		this.Action = new global::Gtk.Action ("Action", null, null, null);
		w1.Add (this.Action, null);
		this.saveAction = new global::Gtk.Action ("saveAction", null, null, "gtk-save");
		w1.Add (this.saveAction, null);
		this.saveAsAction1 = new global::Gtk.Action ("saveAsAction1", null, null, "gtk-save-as");
		w1.Add (this.saveAsAction1, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vBox = new global::Gtk.VBox ();
		this.vBox.Name = "vBox";
		this.vBox.Spacing = 6;
		// Container child vBox.Gtk.Box+BoxChild
		this.labelSaludo = new global::Gtk.Label ();
		this.labelSaludo.Name = "labelSaludo";
		this.labelSaludo.LabelProp = global::Mono.Unix.Catalog.GetString ("Hola mundo");
		this.vBox.Add (this.labelSaludo);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vBox [this.labelSaludo]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vBox.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Introduce tu nombre");
		this.hbox5.Add (this.label2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label2]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.entryNombre = new global::Gtk.Entry ();
		this.entryNombre.CanFocus = true;
		this.entryNombre.Name = "entryNombre";
		this.entryNombre.IsEditable = true;
		this.entryNombre.InvisibleChar = '•';
		this.hbox5.Add (this.entryNombre);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.entryNombre]));
		w4.Position = 1;
		// Container child hbox5.Gtk.Box+BoxChild
		this.buttonAceptar = new global::Gtk.Button ();
		this.buttonAceptar.CanFocus = true;
		this.buttonAceptar.Name = "buttonAceptar";
		this.buttonAceptar.UseStock = true;
		this.buttonAceptar.UseUnderline = true;
		this.buttonAceptar.Label = "gtk-ok";
		this.hbox5.Add (this.buttonAceptar);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.buttonAceptar]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		this.vBox.Add (this.hbox5);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vBox [this.hbox5]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vBox.Gtk.Box+BoxChild
		this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
		this.alignment1.Name = "alignment1";
		// Container child alignment1.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><toolbar name='toolbar1'><toolitem name='openAction' action='openAction'/><toolitem name='saveAction' action='saveAction'/><toolitem name='saveAsAction1' action='saveAsAction1'/></toolbar></ui>");
		this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar1")));
		this.toolbar1.Name = "toolbar1";
		this.toolbar1.ShowArrow = false;
		this.vbox3.Add (this.toolbar1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.toolbar1]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.text1 = new global::Gtk.TextView ();
		this.text1.CanFocus = true;
		this.text1.Name = "text1";
		this.GtkScrolledWindow.Add (this.text1);
		this.vbox3.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow]));
		w9.Position = 1;
		this.alignment1.Add (this.vbox3);
		this.vBox.Add (this.alignment1);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vBox [this.alignment1]));
		w11.Position = 2;
		this.Add (this.vBox);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 432;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.openAction.Activated += new global::System.EventHandler (this.OnOpenActionActivated);
		this.saveAction.Activated += new global::System.EventHandler (this.OnSaveActionActivated);
		this.saveAsAction1.Activated += new global::System.EventHandler (this.OnSaveAsAction1Activated);
		this.buttonAceptar.Clicked += new global::System.EventHandler (this.OnButtonAceptarClicked);
	}
}
