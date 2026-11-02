using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using UserControl_pr1.FolderforModel;//Добавляем папку FolderforModel из проекта UserControl_pr1 для более удобного использования

namespace UserControl_pr1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        //Метод для заполнения данного User Control
        public void Fill(Table_Motorbike Motorbike)//На входе в метод экземпляр класса Table_Motorbike
        {
            labelIDData.Text = Motorbike.ID.ToString();
            labelModelData.Text = Motorbike.Model;
            labelBrandData.Text = Motorbike.Brand;
            labelPriceData.Text = Motorbike.Price.ToString();
            labelHorsepowerData.Text = Motorbike.Horsepower.ToString();
            labelMileageData.Text = Motorbike.Mileage.ToString();

            //Картинки лежат в папке Pictures рядом с exe-файлом (bin\Debug\Pictures)
            Image oldImage = pictureBoxMotorbike.Image;
            pictureBoxMotorbike.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Pictures", Motorbike.Picture));
            if (oldImage != null)
                oldImage.Dispose();
        }
    }
}
