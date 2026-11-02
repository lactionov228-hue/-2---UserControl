using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using UserControl_pr1.FolderforModel;//Добавляем папку FolderforModel из проекта UserControl_pr1 для более удобного использования

namespace UserControl_pr1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static ModelDB DB = new ModelDB();//Глобальная статическая переменная, необходимая для работы с классом ModelDB

        List<Table_Motorbike> Motorbikes = DB.Table_Motorbike.OrderBy(m => m.ID).ToList();//Список класса Table_Motorbike, содержащий данные из одноимённой таблицы SQL
        int AccNumber = 0;//Номер элемента из списка Motorbikes, с которого начинается показ (первый User Control)

        private void Loading()//Первоначальная (обычная) загрузка элементов User Control
        {
            userControl11.Fill(Motorbikes[AccNumber]);//Заполнение 1-го User Control
            userControl12.Fill(Motorbikes[AccNumber + 1]);//Заполнение 2-го User Control
        }

        private void Loading(bool Incr)//Перегрузка метода Loading, чтобы на вход были другие параметры
        {
            if (Incr == true && Motorbikes.Count > AccNumber + 2)//Проверка при нажатии "Листать вправо"
                AccNumber++;
            else if (Incr == false && 0 <= AccNumber - 1)//Проверка при нажатии "Листать влево"
                AccNumber--;
            else
                return;//Если проверка не пройдена, выход из метода

            Loading();
        }

        private void MainForm_Load(object sender, EventArgs e)//Событие загрузки данной формы
        {
            Loading();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            Loading(true);//Перемотка элементов вперёд по списку
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Loading(false);//Перемотка элементов в обратном порядке
        }
    }
}
