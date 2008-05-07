using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace tokenizer
{
    public partial class MainForm : Form
    {
        private Dictionary<string, string> defs;
        private Dictionary<string, string> tokens;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            defs = new Dictionary<string, string>();
            tokens = new Dictionary<string, string>();

            tbOutput.Clear();

            if(!BuildDefinitions( tbDefs.Text ))
            {
                PostError( "Definitions syntax error!" );
                return;
            }
            if( !BuildTokens( tbTokens.Text ) )
            {
                PostError( "Tokens syntax error!" );
                return;
            }

            foreach( KeyValuePair<string, string> k in tokens )
            {
                Match m = Regex.Match( tbInput.Text, k.Key );
                while( m.Success )
                {
                    tbOutput.Text += "* \"" + m.ToString() + "\" is " + k.Value + "\r\n";
                    m = m.NextMatch();
                }
            }
        }

        private void PostError( string p )
        {
            tbOutput.Text = "Error!\n" + p;
        }

        private bool BuildDefinitions( string p )
        {
            string [] list = p.Split( new char[] {'\r', '\n' } );
            foreach( string i in list ) 
            {
                string regex, def;
                string [] line = i.Split( '\t' );
                if(line.Length < 2)
                {
                    continue;
                }
                def   = line[0].Trim();
                regex = line[line.Length-1].Trim();
                defs.Add( def, regex );
            }
            return true;
        }

        private bool BuildTokens( string p )
        {
            string[] list = p.Split( '\n' );
            foreach(string i in list)
            {
                string[] line = i.Split( '\t' );
                if(line.Length < 2)
                {
                    continue;
                }
                string regex, type;
                regex = line[0].Trim();
                type = line[line.Length-1].Trim();
                string outStr = regex;
                foreach( KeyValuePair<string, string> k in defs )
                {
                    outStr = Regex.Replace( outStr, k.Key, k.Value );
                }
                tokens.Add( outStr, type );
            }
            return true;
        }
    }
}
