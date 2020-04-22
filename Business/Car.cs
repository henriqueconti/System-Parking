using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Car
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string carro { get; set; }
        public string placa { get; set; }
        public string cor { get; set; }

        public List<Car> Lista()
        {
            var lista = new List<Car>();
            var CarDB = new Database.Car();
                foreach(DataRow row in CarDB.Lista().Rows)
                {
                var car = new Car();
                car.id = Convert.ToInt32(row["id"]);
                car.nome = row["nome"].ToString();
                car.carro = row["carro"].ToString();
                car.placa = row["placa"].ToString();
                car.cor = row["cor"].ToString();
                
                lista.Add(car);

                }
            return lista;
        }
        public void Save()
        {
            new Database.Car().Salvar(this.id, this.nome, this.carro, this.placa, this.cor);
        }

        public static void Remover(int id)
        {
            new Database.Car().Remover(id);
        }
    }
}
