using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knihovna
{
    public partial class HelpForm : Form
    {
        public HelpForm(string help)
        {
            InitializeComponent();
            if (help == "about")
            {
               label.Text = @"O aplikaci
Aplikace sloužící ke správě knihovny, kde lze přidávat knížky,
uživatelé a jejich práva
Uživatelé mají možnost si knihy půjčovat a vracet

Aplikace vytvořena jako projekt na VOŠ Plzeň v rámci
předmětu Základy programování";
            }
            if (help == "admin")
            {
                label.Text = @"O aplikaci
Na levé straně lze přidávat a odebírat knihy

Na pravé straně lze spravovat uživatele v databázi
Zároveň lze uživatelům měnit heslo
Dvojklikem lze zjistit, jaké knihy má uživatel půjčené

";
            }
            if (help == "user")
            {
                label.Text = @"O aplikaci
V horní části lze vybrat knihu, kterou si uživatel chce 
půjčit a po kliknutí na tlačítko Půjčit si jí půjčí

Půjčené knihy se zobrazují v dolním boxu
Po označení knížky k vrácení a kliknutí na tlačítko
Vrátit knížku vrátí

V menu se uživatel může odhlásit a změnit heslo k účtu

";
            }
        }
    }
}
