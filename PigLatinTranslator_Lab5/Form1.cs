using System.Collections;
using System.Diagnostics;

namespace PigLatinTranslator_Lab5
{
    public partial class frmPigLatinTranslator : Form
    {
        public frmPigLatinTranslator()
        {
            InitializeComponent();
        }


    //brings words that start with a vowel, rearranges them and adds "way"

    private void btnTranslate_Click(object sender, EventArgs e)
        {
            //stores the user's text
            string englishText = Convert.ToString(txtEnglishText.Text);

            //converts the strings into array
            string[] engText = englishText.Split();
            string pigLat = "";
            try
            {
                //check and remembers the word' case
                for (int i = 0; i < engText.Length; i++)
                {
                    foreach (char c in engText[i])
                    {
                        if (c >= 65 || c <= 90)
                        {
                            pigLat += engText[i] + "way";
                        }
                        else if( c>= 97 || c<= 122)
                        {
                            pigLat += engText[i] + "way";
                        }

                        MessageBox.Show(pigLat, "test");
                    

                    /*
                    if (engText[i].StartsWith('a') || engText[i].StartsWith('A'))
                    {
                        //use 'way' at end of strng
                        pigLat += engText[i] + "way";
                    }
                    else if (engText[i].StartsWith('e') || engText[i].StartsWith('E'))
                    {
                        pigLat += engText[i] + "way";
                    }
                    else if (engText[i].StartsWith('i') || engText[i].StartsWith('I'))
                    {
                        pigLat = engText[i] + "way";
                    }
                    else if (engText[i].StartsWith('o') || engText[i].StartsWith('O'))
                    {
                        pigLat = engText[i] + "way";
                    }
                    else if (engText[i].StartsWith('u') || engText[i].StartsWith('U'))
                    {
                        pigLat = engText[i] + "way";
                    }

                    MessageBox.Show(pigLat, "test");*/
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("didn't work\n"+pigLat+"\n"+ex,"eRROR");
            }
            //check if chars in the string have a capital case
           

            /*//tests the array
              string numbersString = "";
            for (int i = 0; i < engText.Length; i++)
                numbersString += engText[i] + "\n";
            MessageBox.Show(numbersString, "Text Checker");
            */





            txtPigLatin.Text = pigLat;
            txtEnglishText.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnglishText.Clear();
            txtPigLatin.Clear();
            txtEnglishText.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
