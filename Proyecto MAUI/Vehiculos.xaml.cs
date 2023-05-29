namespace Proyecto_MAUI;

public partial class Vehiculos : ContentPage
{
	public Vehiculos()
	{
		InitializeComponent();

	}
    private void Automovil_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Caracteristicas del Automovil", "Marca:Toyota" + "Modelo: Corola " + "Color: rojo " + "Año: 2015 " + "Placa: PJM 001456 " + "Tipo: Familiar", "Regresar");
    }

    private void infautomovil_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Informacion Adicional del Automovil", "Las bocinas funciona bien, " + "Capacidad para 8 pasajeros, " + "Menos riesgo de sufrir un acciodente, " + "Acelera facilemnte en menor tiempo, " + "Cuenta con un motor muy potente", "Regresar");
    }
    private void Convertible_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Caracteristicas del Convertible", "Marca:BMW " + "Modelo: Serie 8" + "Color: Cafe " + "Año: 2021 " + "Placa: PJM 988372 " + "Tipo: Carreras", "Regresar");
    }

    private void infconvertible_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Informacion Adicional del Convertible ", "Las bocinas funciona bien, " + "Capacidad para 2 o 4 pasajeros, " + "El techo eretactil, " + "Sensacion de libertad que brinda, " + "Carroceria de tre Volumenes", "Regresar");
    }


    private void Camioneta_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Caracteristicas de la Camioneta", "Marca: Honda " + "Modelo: CRV " + "Color: Blanca " + "Año: 2011 " + "Placa: PJM 985467 " + "Tipo: FAmiliar", "Regresar");
    }

    private void infcamioneta_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Informacion Adicional de la Camioneta", "Las bocinas funciona bien, " + "Capacidad para hasta 9 pasajeros, " + "Su estructura la hace mas segura, " + "Mucho éspacio adicinal, " + "Capacidad para ir por distintos terrenos", "Regresar");
    }


    private void CuatroporCuatro_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Caracteristicas de 4x4", "Marca:RAM" + "Modelo: Pick-up " + "Color: Blanca " + "Año: 2022 " + "Placa: FMT 768893 " + "Tipo: Recargada", "Regresar");
    }
    private void InfCuatroporCuatro_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Informacion Adicional de la 4x4 ", "Las bocinas funciona bien, " + "Capacidad para 8 pasajeros, " + "Menos riesgo de sufrir un acciodente, " + "Acelera facilemnte en menor tiempo, " + "Cuenta con un motor muy potente", "Regresar");
    }
}