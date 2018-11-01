using GeonBit.UI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using GeonBit.UI;
namespace Dragon_For_Honor
{
    class GUI_Interface
    {
         
        public static List<Panel> Windows = new List<Panel>();
         
        public void GUI_Betolt()
        {
            Window_Menu();
            Window_Uj_Jatek();

            Window_Beallitasok();
        }

        public void Window_Keszites(Panel panel)
        {
            Windows.Add(panel);

        }

        public void Window_Menu()
        {
            //entitás készítés
            Panel panel = new Panel(new Vector2(500,430));
            Header header = new Header("Dragon For Honor", Anchor.TopCenter);
            Button Uj_Jatek = new Button("Uj jatek");
            Button Jatek_Betoltes = new Button("Betoltes");
            Button Beallitasok = new Button("Beallitasok");
            Button Kilepes = new Button("Kilepes");
             
            UserInterface.Active.AddEntity(panel);

            //add entitás
            panel.AddChild(header);
            panel.AddChild(Uj_Jatek);
            panel.AddChild(Jatek_Betoltes);
            panel.AddChild(Beallitasok);
            panel.AddChild(Kilepes);

            //onclick

            Uj_Jatek.OnClick += (Entity entity) =>
            {
                Menu_Manager.Menu_Valtas(Menu_Manager.Menu.Uj_Jatek);
            };

            Uj_Jatek.OnClick += (Entity entity) =>
            {
                Menu_Manager.Menu_Valtas(Menu_Manager.Menu.Uj_Jatek);
            };

            Kilepes.OnClick += (Entity kilep) =>
            {

                Game1.kilep=true;
              };

            //Window csinálás
            Window_Keszites(panel);
        }
        public void Window_Uj_Jatek()
        {
            Panel panel = new Panel(new Vector2(600, 500));
            Header fent_kozep = new Header("Valassza ki a nehezsegi szintet!", Anchor.TopCenter);
            RadioButton Konnyu = new RadioButton("Konnyu");
            RadioButton Kozepes = new RadioButton("Kozepes");
            RadioButton Nehez = new RadioButton("Nehez");
            CheckBox targyak_elvesztese = new CheckBox("Targyak elvesztese");
            CheckBox vegleges_halal = new CheckBox("Vegleges halal");

           
            Button Vissza = new Button("Vissza");
            Konnyu.Checked=true;
            Button Jatek_Inditasa = new Button("Jatek inditasa");

            UserInterface.Active.AddEntity(panel);






            panel.AddChild(fent_kozep);
            panel.AddChild(Konnyu);
            panel.AddChild(Kozepes);
            panel.AddChild(Nehez);
            panel.AddChild(targyak_elvesztese);
            panel.AddChild(vegleges_halal);
            panel.AddChild(Jatek_Inditasa);
            panel.AddChild(Vissza);

            Vissza.OnClick += (Entity vissza) =>
              {
                  Menu_Manager.Menu_Valtas(Menu_Manager.Menu.Fo_Menu);
              };





            Window_Keszites(panel);

        }
        public void Window_Jatek_Betoltes()
        {

        }
        public void Window_Beallitasok()
        {
            Panel panel = new Panel(new Vector2(600, 500));
            Header fent_kozep = new Header("Beallitasok", Anchor.TopCenter);
            
 


            Button Vissza = new Button("Vissza");
 
             

            UserInterface.Active.AddEntity(panel);






            panel.AddChild(fent_kozep);
 
 
             
            panel.AddChild(Vissza);

            Vissza.OnClick += (Entity vissza) =>
            {
                Menu_Manager.Menu_Valtas(Menu_Manager.Menu.Fo_Menu);
            };


            Window_Keszites(panel);
        }
        
    }
}
