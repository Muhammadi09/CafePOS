using System.Windows.Forms;

namespace System
{
    internal class KeyPressEventHandler
    {
        private object txtInput1_TextChanged;
        private Action<object, KeyPressEventArgs> textBox2_TextChanged;

        public KeyPressEventHandler(object txtInput1_TextChanged)
        {
            this.txtInput1_TextChanged = txtInput1_TextChanged;
        }

        public KeyPressEventHandler(Action<object, KeyPressEventArgs> textBox2_TextChanged)
        {
            this.textBox2_TextChanged = textBox2_TextChanged;
        }
    }
}