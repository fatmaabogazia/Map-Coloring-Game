using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SolverFoundation.Common;
using Microsoft.SolverFoundation.Services;


namespace Coloring_Map_AI
{

    public partial class Map_Coloring : Form
    {
        public Map_Coloring()
        {
            InitializeComponent();

            InitializeRegions();

            comboBox1.SelectedIndexChanged += (sender, e) =>
            {
                // The () معناها ان انا بخلي اللون اللي اخترته ك string 
                string colorArea = (string)comboBox1.SelectedItem;
                // الداله FromName تستخدم لتحويل اسم اللون للون حقيقي
                // Set the color of the button                
                comboBox1.BackColor = Color.FromName(colorArea);
            };

        }

        private List<Label> regions;
        private void InitializeRegions()
        {
            // Add labels to the list
            regions = new List<Label> { egypt, jordon, palestine, tunisia, libya, djibouti };
        }


        private void ShuffleColors()
        {
            // Create a list of available colors
            List<Color> availableColors = new List<Color> { Color.Red, Color.Green, Color.Blue };

            // Shuffle the list
            Random rng = new Random();
            int n = availableColors.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Color value = availableColors[k];
                availableColors[k] = availableColors[n];
                availableColors[n] = value;
            }

            // Assign colors to the regions ensuring no adjacent regions have the same color
            for (int i = 0; i < regions.Count; i++)
            {
                // Get the colors of the neighboring regions
                Color leftColor = regions[(i - 1 + regions.Count) % regions.Count].BackColor;
                Color rightColor = regions[(i + 1) % regions.Count].BackColor;

                // Remove the neighboring colors from the available colors list
                List<Color> available = new List<Color>(availableColors);
                available.Remove(leftColor);
                available.Remove(rightColor);

                // Assign a random color from the remaining available colors
                regions[i].BackColor = available[rng.Next(available.Count)];
            }
        }

        private void ColorRegions()
        {
           // ShuffleColors();

            var context = SolverContext.GetContext();
            
            var model = context.CreateModel();

            // Define the colors domain
            Domain colors = Domain.Enum("Red", "Green", "Blue");

            // Create decision variables for each region
            Decision[] decisions = new Decision[regions.Count];

            for (int i = 0; i < regions.Count; i++)
            {
                decisions[i] = new Decision(colors, $"Region_{i}");
                model.AddDecision(decisions[i]);
            }

            model.AddConstraint("Constraint_0", decisions[0] != decisions[1]);
            model.AddConstraint("Constraint_1", decisions[0] != decisions[2]);
            model.AddConstraint("Constraint_2", decisions[1] != decisions[2]);
            model.AddConstraint("Constraint_3", decisions[2] != decisions[3]);
            model.AddConstraint("Constraint_4", decisions[0] != decisions[4]);

            //Solve the model
            Solution solution = context.Solve(new ConstraintProgrammingDirective());
            if (solution.Quality == SolverQuality.Feasible)
            {
                // Assign colors to regions based on the solution
                for (int i = 0; i < regions.Count; i++)
                {
                    regions[i].BackColor = GetColorFromString(decisions[i].ToString());
                }
            }
            else
            {
                MessageBox.Show("No feasible solution found.");
            }
        }

        private Color GetColorFromString(string colorString)
        {
            switch (colorString)
            {
                case "Red":
                    return Color.Red;
                case "Green":
                    return Color.Green;
                case "Blue":
                    return Color.Blue;
                default:
                    return Color.White;
            }
        }

        private void Map_Coloring_Load(object sender, EventArgs e)
        {
            //  ShuffleColors();
        }

        private void ai_butt_Click(object sender, EventArgs e)
        {
            //ShuffleColors();
            ColorRegions();
        }

        private void submit_Click(object sender, EventArgs e)
        {
      
            if (egypt.BackColor==jordon.BackColor || egypt.BackColor == palestine.BackColor || egypt.BackColor == libya.BackColor || egypt.BackColor == Color.White)
            {
                MessageBox.Show("Incorrect Map Coloring");
            }
            else if(jordon.BackColor==palestine.BackColor||jordon.BackColor==Color.White)
            {
                MessageBox.Show("Incorrect Map Coloring");
            }
            else if(palestine.BackColor==tunisia.BackColor ||palestine.BackColor==Color.White)
            {
                MessageBox.Show("Incorrect Map Coloring");
            }
            else if (tunisia.BackColor == Color.White)
            {
                MessageBox.Show("Incorrect Map Coloring");
            }
            else if (libya.BackColor == Color.White)
            {
                MessageBox.Show("Incorrect Map Coloring");
            }
            else if (djibouti.BackColor == Color.White)
            {
                MessageBox.Show("Incorrect Map Coloring");
            }
            else
            {
                MessageBox.Show("Correct Map Coloring");
            }

        }

        private void CrossButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReturnButtom_Click(object sender, EventArgs e)
        {
            egypt.BackColor = Color.White;
            jordon.BackColor = Color.White;
            palestine.BackColor = Color.White;
            tunisia.BackColor = Color.White;
            libya.BackColor = Color.White;
            djibouti.BackColor = Color.White;
        }

        private void egypt_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;           
            string color = comboBox1.SelectedItem.ToString();
            Color regionColor = Color.FromName(color);
            label.BackColor = regionColor;
        }

        private void jordon_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string color = comboBox1.SelectedItem.ToString();
            Color regionColor = Color.FromName(color);
            label.BackColor = regionColor;
        }

        private void palestine_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;        
            string color = comboBox1.SelectedItem.ToString();
            Color regionColor = Color.FromName(color);
            label.BackColor = regionColor;
        }

        private void tunisia_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string color = comboBox1.SelectedItem.ToString();
            Color regionColor = Color.FromName(color);
            label.BackColor = regionColor;
        }

        private void libya_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string color = comboBox1.SelectedItem.ToString();
            Color regionColor = Color.FromName(color);
            label.BackColor = regionColor;
        }

        private void djibouti_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string color = comboBox1.SelectedItem.ToString();
            Color regionColor = Color.FromName(color);
            label.BackColor = regionColor;
        }

    }
}












