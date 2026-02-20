using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    class Car
    {
        private double tankVolume = 60;
        private double petrolVolume = 0;
        private double expenses = 6;
        private double mileage = 0;
        public Car(double tankVolume, double petrolVolume, double expenses, double mileage)
        {
            this.tankVolume = tankVolume;
            this.petrolVolume = petrolVolume;
            this.expenses = expenses;
            this.mileage = mileage;
        }
        public double TankVolume()
        {
            return Math.Round(tankVolume, 2);
        }
        public void TankVolume(double volume)
        {
            if (volume > 0)
            {
                tankVolume = volume;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Объем бака должен быть\nположительным и больше 0!",
                    "Error", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public double PetrolVolume()
        {
            return Math.Round(petrolVolume, 2);
        }
        public void PetrolVolume(double volume)
        {
            if (volume > 0 && volume <= tankVolume)
            {
                petrolVolume = volume;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Количество бензина должен быть\nположительным, больше 0" +
                    "\nи не превышать объем бака!", "Error", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public double Expenses()
        {
            return Math.Round(expenses, 2);
        }
        public void Expenses(double liter)
        {
            if (liter > 0)
            {
                petrolVolume = liter;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Потребление бензина должено быть" +
                    "\nположительным и больше 0!", "Error", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public double Mileage()
        {
            return Math.Round(mileage, 2);
        }
        public void Mileage(double kilometer)
        {
            if (kilometer >= 0)
            {
                petrolVolume = kilometer;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Количество бензина должен быть положительным!",
                    "Error", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public string CarInfo()
        {
            return String.Format("Объем бака: \t\t\t{0:F2} л" +
                "\nКоличество бензина в баке: \t{1:F2} л" +
                "\nРасход бензина на 100 км: \t\t{2:F2} л" +
                "\nПробег автомобиля: \t\t{3:F2} км", tankVolume, petrolVolume, expenses, mileage);
        }
        public double FillCarUp(double liters)
        {
            if (liters <= tankVolume - petrolVolume)
            {
                petrolVolume += liters;
                return 0;
            }
            else
            {
                petrolVolume = tankVolume;
                liters = liters - (tankVolume - petrolVolume);
                return liters;
            }
        }
        public bool NeedPetrol()
        {
            return petrolVolume < (tankVolume * 0.1);
        }
        public void Drive(double wholeWay)
        {
            double feasibleWay = (petrolVolume / expenses) * 100;
            if (wholeWay > feasibleWay)
            {
                double sliceOfWay = wholeWay - feasibleWay;
                mileage += feasibleWay;
                petrolVolume = 0;
                System.Windows.Forms.MessageBox.Show($"Бензина хватило только на {feasibleWay:F2} км." +
                    $"\nНе доехали {sliceOfWay:F2} км.", "Бензин кончился!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information);
            }
            else
            {
                petrolVolume -= (wholeWay * expenses) / 100;
                int thousandsBefore = (int)(mileage / 1000);
                mileage += wholeWay;
                int thousandsAfter = (int)(mileage / 1000);
                if (thousandsAfter > thousandsBefore)
                {
                    int dif = thousandsAfter - thousandsBefore;
                    expenses += 0.1 * dif;
                    System.Windows.Forms.MessageBox.Show($"Пробег превысил {thousandsAfter * 1000} км." +
                    $"\nРасход увеличен до {expenses:F2} л на 100 км.", "Износ двигателя!",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information);
                }
            }
        }
    }
}
