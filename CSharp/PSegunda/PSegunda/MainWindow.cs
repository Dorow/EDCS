using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	int aux1, aux2,aux3,aux4;
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		resultado.Text = "";
		resto.Text = "";

		aux1 = int.Parse (entry1.Text);
		aux2 = int.Parse (entry2.Text);
		aux3 = aux1 + aux2;

		resultado.Text = aux3.ToString();;
	}

	protected void OnRestClicked (object sender, EventArgs e)
	{
		resultado.Text = "";
		resto.Text = "";

		aux1 = int.Parse (entry1.Text);
		aux2 = int.Parse (entry2.Text);
		aux3 = aux1 - aux2;

		resultado.Text = aux3.ToString();;
	}

	protected void OnMultClicked (object sender, EventArgs e)
	{
		resultado.Text = "";
		resto.Text = "";

		aux1 = int.Parse (entry1.Text);
		aux2 = int.Parse (entry2.Text);
		aux3 = aux1 * aux2;

		resultado.Text = aux3.ToString();;
	}

	protected void OnDivClicked (object sender, EventArgs e)
	{
		resultado.Text = "";
		resto.Text = "";

		aux1 = int.Parse (entry1.Text);
		aux2 = int.Parse (entry2.Text);
		aux3 = aux1 / aux2;
		aux4 = aux1 % aux2;

		resultado.Text = aux3.ToString();
		resto.Text = aux4.ToString ();
	}
}
