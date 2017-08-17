using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace COMP123_S2017_FinalExam_StudentID
{
    class ScoreBoard
    #region fields and variables
    {
        //Private Instance Variables
        private int _score;
        private int _time;
        private TextBox _finalScoreTextBox;
        private TextBox _scoreTextBox;
        private TextBox _timeTextBox;

        // Public Properties
        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }             
        }
        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
            }
        }
        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
            }
        }
        #endregion
        // Constructor
        ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {

        }

        void UpdateTime()
        {
            int time = Convert.ToInt32(TimeTextBox.Text);
            time--;
            int newTime = time;
            this.Time = newTime;
            this.TimeTextBox.Text = Convert.ToString(newTime);
        }
    }
}
