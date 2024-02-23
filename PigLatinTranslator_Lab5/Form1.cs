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


        //method to store boolean of ic capital
        public static bool isCapital(string eng)
        {
            bool isCap = false;
           

            return isCap;
        }
    private void btnTranslate_Click(object sender, EventArgs e)
        {
            //stores the user's text
            string englishText = Convert.ToString(txtEnglishText.Text);
            //declares the translation to pig latin
            string pigLat = txtPigLatin.Text;
            pigLat = "";
            //converts the strings into array
            string[] engText = englishText.Split();
            
            try
            {

                                               
                bool isCapital = false;
                bool isVowel = false;
                bool hasLetters = false;

                //check and remembers the word' case
                for (int i = 0; i < engText.Length; i++)
                {
                    
                    foreach (char c in engText[i])
                    {
                        
                       if (c >= 65 && c<= 90)
                       {
                            hasLetters = true;
                            isCapital = true;

                            switch (c)
                            {
                                case 'A':                                   
                                   // continue;
                                case 'E':
                                   // continue;
                                case 'I':
                                   // continue;
                                case 'O':
                                   // continue;
                                case 'U':
                                    isVowel = true;                                    
                                    continue;

                            }

                            
                       }
                       else
                       {
                            hasLetters = false;
                           isCapital = false;
                            switch (c)
                            {
                                case 'a':
                                // continue;
                                case 'e':
                                // continue;
                                case 'i':
                                // continue;
                                case 'o':
                                // continue;
                                case 'u':
                                    isVowel = true;
                                    continue;

                            }

                        }

                    }
                }
               MessageBox.Show(pigLat + isVowel + isCapital , "test");
            }
            catch (Exception ex)
            {
                MessageBox.Show("did not work\n"+pigLat+"\n"+ex,"eRROR");
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
