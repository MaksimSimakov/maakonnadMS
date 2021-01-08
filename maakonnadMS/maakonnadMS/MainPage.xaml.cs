using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace maakonnadMS
{
    public partial class MainPage : ContentPage
    {
        private Picker stol;
        public MainPage()
        {
            Picker picker;
            Entry entry;
            Image img;
            {
                Grid gr = new Grid
                {
                    RowDefinitions =
                    {
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    },
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                    }
                };
                picker = new Picker
                {
                    Title = "Уезды Эстонии"
                };
                picker.Items.Add("Валгамаа");
                picker.Items.Add("Вильяндимаа");
                picker.Items.Add("Вырумаа");
                picker.Items.Add("Ида-Вирумаа");
                picker.Items.Add("Йыгевамаа");
                picker.Items.Add("Ляэне-Вирумаа");

                gr.Children.Add(picker, 0, 0);
                picker.SelectedIndexChanged += Picker_SelectedIndexChanged;

                stol = new Picker
                {
                    Title = "Административные центры уездов"
                };
                stol.Items.Add("Валга");
                stol.Items.Add("Вильянди");
                stol.Items.Add("Выру");
                stol.Items.Add("Йихви");
                stol.Items.Add("Йигева");
                stol.Items.Add("Раквере");

                gr.Children.Add(stol, 0, 0);

                stol.SelectedIndexChanged += Stol_SelectedIndexChanged;
                entry = new Entry
                {
                    Text = "Уезд"
                };
                gr.Children.Add(entry, 1, 1);

                img = new Image
                {
                    Source = "harju.jpg"
                };
                {
                    if (stol.SelectedIndex == 0)
                    {
                        img.Source = "valgamaa.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 1)
                    {
                        img.Source = "viljandimaa.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 2)
                    {
                        img.Source = "vorumaa.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 3)
                    {
                        img.Source = "idaviru.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 4)
                    {
                        img.Source = "jogevamaa.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 5)
                    {
                        img.Source = "laavirumaa.jpg";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }


                }
                {
                    if (picker.SelectedIndex == 0)
                    {
                        img.Source = "valgamaa.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Уезд Валгамаа расположен в южной части Эстонии. Этот регион граничит с Латвийской республикой. Административным центром уезда является город Валга, побратимом которого считается латвийский Валка. В некоторой степени эти города составляют единое целое, однако административно они разделены границей.";
                    }
                    else if (picker.SelectedIndex == 1)
                    {
                        img.Source = "viljandimaa.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Ви́льяндимаа — уезд в Эстонии, расположенный в южной части страны. Административный центр — город Вильянди. Уезд состоит из трёх городов и 9 волостей.";
                    }
                    else if (picker.SelectedIndex == 2)
                    {
                        img.Source = "vorumaa.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Вырумаа (эст. Võrumaa или Võru maakond, выруск. Võromaa или Võro maakund) — уезд в Эстонии, расположенный в юго-восточной части страны. Граничит с Россией, Латвией, уездами Валгамаа и Пылвамаа. Административный центр — город Выру (тж. Верро). Уезд в административном отношении делится на один город и 4 волости (с 2017 года).";
                    }
                    else if (picker.SelectedIndex == 3)
                    {
                        img.Source = "idaviru.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "И́да-Ви́румаа (эст. Ida-Virumaa), или И́да-Ви́руский уезд (эст. Ida-Viru maakond) — уезд (мааконд) на северо-востоке Эстонии, граничит на севере и востоке с Россией. Территория уезда простирается до Финского залива на севере, до реки Нарвы на востоке и до Чудского озера на юге. На западе и юго-западе уезда граница тянется через леса и болота Алутагузе[2], вдоль территории Ляэне-Вируского и Йыгеваского уездов. Площадь Ида-Вирумаа — 3364,05 км², что составляет 7,4 % от площади всей Эстонии. В середине северной части уезда, в 165 км от Таллина, находится административный центр Ида-Вирумаа — город Йыхви. ";
                    }
                    else if (picker.SelectedIndex == 4)
                    {
                        img.Source = "jogevamaa.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Йыгевамаа (эст. Jõgevamaa или Jõgeva maakond) — уезд в Эстонии, расположенный в восточной части страны. Административный центр — город Йыгева. Уезд в административном отношении делится на 3 города и 10 волостей. ";
                    }
                    else if (picker.SelectedIndex == 5)
                    {
                        img.Source = "laavirumaa.jpg";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Ля́эне-Ви́румаа (эст. Lääne-Virumaa или Lääne-Viru maakond) — уезд в Эстонии, расположенный в северо-восточной части страны. Административный центр — город Раквере. ";
                    }

                }
                {
                }
            }
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Stol_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
    
}
