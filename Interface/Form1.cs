using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    
    public partial class Form1 : Form
    {
        Config cfg;
        
        

        public Form1()
        {
            InitializeComponent();

            Name.Text = cfg.Name;
            Age.Text = (cfg.Age).ToString();
            Gender.Text = cfg.Gender;


            HealthBar.Value = 90;
            FoodBar.Value = 90;
            HappinessBar.Value = 90;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HealthBar.Value += 10;
            } catch(System.ArgumentOutOfRangeException)
            {
                HealthBar.Value = 100;
            }
            try
            {
                FoodBar.Value -= 4;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Dead(ref cfg);
            }
            try
            {
                HappinessBar.Value -= 4;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Dead(ref cfg);
            }
            if (HappinessBar.Value <= 0 || FoodBar.Value <= 0 || HappinessBar.Value <= 0)
            {
                Dead(ref cfg);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                HappinessBar.Value += 10;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                HappinessBar.Value = 100;
            }
            try
            {
                FoodBar.Value -= 4;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Dead(ref cfg);
            }
            try
            {
                HealthBar.Value -= 4;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Dead(ref cfg);
            }
            if (HappinessBar.Value <= 0 || FoodBar.Value <= 0 || HappinessBar.Value <= 0)
            {
                Dead(ref cfg);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FoodBar.Value += 10;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                FoodBar.Value = 100;
            }
            try
            {
                HealthBar.Value -= 4;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Dead(ref cfg);
            }
            try
            {
                HappinessBar.Value -= 4;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Dead(ref cfg);
            }
            if (HappinessBar.Value <= 0 || FoodBar.Value <= 0 || HappinessBar.Value <= 0)
            {
                Dead(ref cfg);
            }
        }
        private void Dead(ref Config cfg)
        {
            HappinessBar.Value = 0;
            HealthBar.Value = 0;
            FoodBar.Value = 0;
            Hide();
            GbScreen Dead = new GbScreen();
            Dead.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dead(ref cfg);
        }
        
    }
}
