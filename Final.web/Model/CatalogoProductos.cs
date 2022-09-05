namespace Final.web.Model
{
    public class CatalogoProductos
    {
        public List<Productos> productos { get; set; }

        public CatalogoProductos()
        {

            productos = new List<Productos>()
            {
                new Productos { id =01,Nombre="TELEVISOR", Stockactual=50,Stockminimo= 5,},
                new Productos { id =02,Nombre="RADIO",  Stockactual=70,Stockminimo= 15,},
                new Productos { id =03,Nombre="LAVARROPAS", Stockactual=60,Stockminimo= 20,},
                new Productos { id =04,Nombre="CELULAR",  Stockactual=200,Stockminimo= 20,},
                new Productos { id =05,Nombre="MICROONDAS",  Stockactual=50,Stockminimo= 10,},


            };


        }


        public Productos FindById(int id) // Usado
        {
            Productos encontrado = null;

            foreach (Productos item in productos)
            {
                if (item.id == id)
                {
                    encontrado = item;
                    break;
                }
            }

            return encontrado;
        }


        public int Obtenertotal()
        {
            return productos.Sum(Productos => Productos.Stockactual);

        }




    }


}

