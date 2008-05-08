using System;
using System.Collections.Generic;
using System.Drawing;
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

            lvOutput.Items.Clear();

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
            /*
            foreach( KeyValuePair<string, string> k in tokens )
            {
                Match m = Regex.Match( tbInput.Text, k.Key );
                while( m.Success )
                {
                    //tbOutput.Text += "\"" + m.ToString() + "\" is " + k.Value + "\r\n";
                    lvOutput.Items.Add( new ListViewItem( new string[] { m.ToString(), k.Value } ) );
                    m = m.NextMatch();
                }
            }
            */

            InBuffer ib = new InBuffer(tbInput.Text);
            int matches = 0, previous = 0;
            string result = "";
            bool firstRun = true;

            while(!ib.IsEnd) 
            {
                while(true)
                {
                    string src = ib.Move();
                    previous = matches;
                    matches = 0;

                    foreach(KeyValuePair<string, string> k in tokens)
                    {
                        MatchCollection m = Regex.Matches( src, "^" + k.Key + "$" );
                        matches += m.Count;
                    }

                    if(matches > 1) continue;
                    if(matches == 0 && previous == 1)
                    {
                        result = ib.MoveBack();
                        break;
                    }

                    if(ib.IsEnd)
                    {
                        result = ib.Accept();
                        break;
                    }
                }
                ib.Accept();
                foreach(KeyValuePair<string, string> k in tokens)
                {
                    Match m = Regex.Match( result, "^" + k.Key + "$" );
                    if(m.Success)
                    {
                        lvOutput.Items.Add( new ListViewItem( new string[] { m.ToString(), k.Value } ) );
                        break;
                    }
                }
            }
        }

        private void PostError( string p )
        {
            //tbOutput.Text = "Error!\n" + p;
            MessageBox.Show( p, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
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
