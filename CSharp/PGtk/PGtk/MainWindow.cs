using System;
using System.IO;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	private String filename;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		Label label = new Label ("Este lo he añadido a mano");
		label.Visible = true;
		vBox.Add (label);
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButtonAceptarClicked (object sender, EventArgs e)
	{
		labelSaludo.Text = "Hola " + entryNombre.Text;
	}


	protected void OnOpenActionActivated (object sender, EventArgs e)
	{
		FileChooserDialog fileChooserDialog = new FileChooserDialog (
			"Elige una opcion",
			this,
			FileChooserAction.Open,
			Stock.Cancel, ResponseType.Cancel,
			Stock.Open, ResponseType.Ok);

		if (fileChooserDialog.Run () == (int)ResponseType.Ok) {
			filename = fileChooserDialog.Filename;
			text1.Buffer.Text = File.ReadAllText (filename);

		}
		fileChooserDialog.Destroy();
	}
	
	protected void OnSaveActionActivated (object sender, EventArgs e)
	{
		if (filename == null)
			saveAs ();
		else
			File.WriteAllText (filename,text1.Buffer.Text);
	}
	
	protected void OnSaveAsAction1Activated (object sender, EventArgs e)
	{
		saveAs ();
	}

	private void saveAs(){
		FileChooserDialog fileChooserDialog = new FileChooserDialog (
			"Guardar",
			this,
			FileChooserAction.Save,
			Stock.Cancel, ResponseType.Cancel,
			Stock.Save, ResponseType.Ok);

		if (fileChooserDialog.Run () == (int)ResponseType.Ok)
			File.WriteAllText (fileChooserDialog.Filename,text1.Buffer.Text);

		fileChooserDialog.Destroy();
	}
}
