namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public Cuenta() 
        { 
        
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public void SetTitular(string titular)
        {
            if (!string.IsNullOrWhiteSpace(titular))
            {
                this.titular = titular;
            }
        }

        public void Ingresar(double ingreso)
        {
            if(ingreso > 0) 
            {
                //this.cantidad = this.cantidad + ingreso;
                this.cantidad += ingreso;
            } 
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            //return "El titular es " + this.titular + " y la cantidad de dinero es " + this.cantidad;
            //return string.Format("el titular es {0} y la cantidad de dinero es {1}", this.titular, this.cantidad);
            return $"El titular es {this.titular} y la cantidad de dinero es {this.cantidad}";
        }

        public void Retirar(double cantidad)
        {
            this.cantidad -= cantidad;
        }
    }
}