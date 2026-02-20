using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Car[] cars = new Car[10];
        int amountCars = -1;
        private void buttonRecord_Click(object sender, EventArgs e)
        {
            try
            {
                amountCars++;
                if (double.TryParse(textTank.Text, out double valumeTank)
                    && double.TryParse(textPetrol.Text, out double valumePetrol)
                    && double.TryParse(textCost.Text, out double cost)
                    && double.TryParse(textWay.Text, out double way))
                {
                    if (valumePetrol >= 0 && valumeTank > 0 && cost > 0 && way >= 0 && valumePetrol <= valumeTank)
                    {
                        cars[amountCars] = new Car(valumeTank, valumePetrol, cost, way);
                        if (amountCars >= cars.Length - 1)
                        {
                            amountCars = -1;
                            MessageBox.Show("Память заполнена!\nДальнейшие записи будут записываться заново,\nзамненяя старые.",
                                "Переполнение памяти", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введнные значение не должны быть отрицательными!\nКоличнство бензина и пробег могут быть равны 0.\nКоличество бензина не должно превышать объем бака", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("неверный формат данных", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            RecordsOfCars.Columns.Clear();
            RecordsOfCars.Rows.Clear();
            RecordsOfCars.ColumnCount = 4;
            RecordsOfCars.RowCount = cars.Length;
            RecordsOfCars.Columns[0].HeaderCell.Value = "Объем бака (л)";
            RecordsOfCars.Columns[1].HeaderCell.Value = "Бензин в баке (л)";
            RecordsOfCars.Columns[2].HeaderCell.Value = "Расход (л/100км)";
            RecordsOfCars.Columns[3].HeaderCell.Value = "Пробег (км)";
            for (int i = 0; i < RecordsOfCars.RowCount; i++)
            {
                if (cars[i] != null)
                {
                    RecordsOfCars.Rows[i].HeaderCell.Value = "Автомобиль " + (i + 1);
                    RecordsOfCars[0, i].Value = cars[i].TankVolume();
                    RecordsOfCars[1, i].Value = cars[i].PetrolVolume();
                    RecordsOfCars[2, i].Value = cars[i].Expenses();
                    RecordsOfCars[3, i].Value = cars[i].Mileage();
                }
            }
        }
        private void buttonRefuelThisCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (amountCars < 0)
                {
                    double liters = cars[0].FillCarUp(Convert.ToDouble(textBox1.Text));
                    if (liters == 0)
                    {
                        infoAfterFillCarUp.Text = "Бензин в баке (л): " + cars[0].PetrolVolume();
                    }
                    else
                    {
                        infoAfterFillCarUp.Text = "Бензин в баке (л): " + cars[0].PetrolVolume()
                            + $"\nОставшийся бензин (л): " + liters;
                    }
                }
                else
                {
                    double liters = cars[amountCars].FillCarUp(Convert.ToDouble(textBox1.Text));
                    if (liters == 0)
                    {
                        infoAfterFillCarUp.Text = "Бензин в баке (л): " + cars[amountCars].PetrolVolume();
                    }
                    else
                    {
                        infoAfterFillCarUp.Text = "Бензин в баке (л): " + cars[amountCars].PetrolVolume()
                            + $"\nОставшийся бензин (л): " + liters;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите корректное число литров", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDriveThis_Click(object sender, EventArgs e)
        {
            try
            {
                if (amountCars < 0)
                {
                    cars[0].Drive(Convert.ToDouble(textBox2.Text));
                    infoAfterWay.Text = $"Объем бака: \t{cars[0].TankVolume():F2} л" +
                    $"\nКоличество бензина в баке: \t{cars[0].PetrolVolume():F2} л" +
                    $"\nРасход бензина на 100 км: \t{cars[0].Expenses():F2}  л" +
                    $"\nПробег автомобиля: \t{cars[0].Mileage():F2} км";
                }
                else
                {
                    cars[amountCars].Drive(Convert.ToDouble(textBox2.Text));
                    infoAfterWay.Text = $"Объем бака: \t{cars[amountCars].TankVolume():F2} л" +
                    $"\nКоличество бензина в баке: \t{cars[amountCars].PetrolVolume():F2} л" +
                    $"\nРасход бензина на 100 км: \t{cars[amountCars].Expenses():F2}  л" +
                    $"\nПробег автомобиля: \t{cars[amountCars].Mileage():F2} км";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите корректное расстояние", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefuelSelectedCar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = RecordsOfCars.CurrentCell.RowIndex;
                if (index >= 0 && index < cars.Length && cars[index] != null)
                {
                    double liters = cars[index].FillCarUp(Convert.ToDouble(textBox1.Text));
                    if (liters == 0)
                    {
                        infoAfterFillCarUp.Text = "Бензин в баке (л): " + cars[index].PetrolVolume();
                    }
                    else
                    {
                        infoAfterFillCarUp.Text = "Бензин в баке (л): " + cars[index].PetrolVolume()
                            + $"\nОставшийся бензин (л): " + liters;
                    }
                }
                else
                {
                    MessageBox.Show("Выберите автомобиль в таблице", "Выбор!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите корректное число литров", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDriveSelected_Click(object sender, EventArgs e)
        {
            try
            {
                int index = RecordsOfCars.CurrentCell.RowIndex;
                if (index >= 0 && index < cars.Length && cars[index] != null)
                {
                    cars[index].Drive(Convert.ToDouble(textBox2.Text));
                    infoAfterWay.Text = $"Объем бака: \t{cars[index].TankVolume():F2} л" +
                    $"\nКоличество бензина в баке: \t{cars[index].PetrolVolume():F2} л" +
                    $"\nРасход бензина на 100 км: \t{cars[index].Expenses():F2} л" +
                    $"\nПробег автомобиля: \t{cars[index].Mileage():F2} км";
                }
                else
                {
                    MessageBox.Show("Выберите автомобиль в таблице", "Выбор!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите корректное расстояние", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
