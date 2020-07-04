using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace BeeBreeding
{
    internal class VM : INotifyPropertyChanged
    {
        const int INITIAL_VALUE = 0;
        const int ONE = 1;
        const int TWO = 2;
        const int THREE = 3;
        const int FOUR = 4;
        const int FIVE = 5;

        private string inputNumber;
        public string InputNumber
        {
            get { return inputNumber; } 
            set { inputNumber = value; Changed(); }
        }
        readonly List<string> Input = new List<string>();
        public ObservableCollection<string> Output { get; set; } = new ObservableCollection<string>();
        public void AddInputToList()
        {
            if (InputNumber == "0 0")
            {
                Reset();
            }
            else
            {
                Input.Add(InputNumber);
                Output.Clear();
                ExtractHexagonCells();
                InputNumber = string.Empty;
            }
        }
        public void ExtractHexagonCells()
        {
            try
            {
                foreach (string number in Input)
                {
                    string[] inputArray = number.Split(' ');
                    int[] HexagonArray = new int[2];
                    HexagonArray[0] = int.Parse(inputArray[0]);
                    HexagonArray[1] = int.Parse(inputArray[1]);
                    if (HexagonArray[0] > 10000 || HexagonArray[1] > 10000 || HexagonArray[0] <= 0 || HexagonArray[1] <= 0)
                    {
                        InputNumber = string.Empty;
                    }
                    else
                    {
                        DistanceCalculation(HexagonArray[0], HexagonArray[1]);
                    }
                }
            }
            catch
            {
                InputNumber = string.Empty;
                Input.RemoveAt(Input.Count - 1);
            }
        }
        public void DistanceCalculation(int firstValue, int secondValue)
        {
            int result = INITIAL_VALUE;
            if (firstValue == INITIAL_VALUE && secondValue == INITIAL_VALUE)
            {
                Output.Add(result.ToString());
            }
            else
            {
                Point p = new Point(INITIAL_VALUE, INITIAL_VALUE);
                p = CalculateCoordinates(firstValue);
                Point point1 = new Point(p.getX(), p.getY());
                p = CalculateCoordinates(secondValue);
                Point point2 = new Point(p.getX(), p.getY());
                int x = point1.getX() - point2.getX();
                int y = point1.getY() - point2.getY();
                if (x * y <= INITIAL_VALUE)
                    result = Math.Max(Math.Abs(x), Math.Abs(y));
                else
                    result = Math.Abs(x + y);
                Output.Add("The distance between " + firstValue + " and " + secondValue + " is: " + result.ToString());
            }
        }
        public static Point CalculateCoordinates(int hexagonNumber)
        {
            if (hexagonNumber == ONE)
            {
                return new Point(INITIAL_VALUE, INITIAL_VALUE);
            }
            int x;
            int y;
            int level = ONE;
            while (THREE * (level - ONE) * level + ONE < hexagonNumber)
                level++;
            level--;
            hexagonNumber -= THREE * (level - ONE) * level + ONE;
            if (hexagonNumber <= level)
            {
                x = level;
                y = -hexagonNumber;
            }
            else if (hexagonNumber <= TWO * level)
            {
                x = TWO * level - hexagonNumber;
                y = -level;
            }
            else if (hexagonNumber <= THREE * level)
            {
                x = TWO * level - hexagonNumber;
                y = -level - x;
            }
            else if (hexagonNumber <= FOUR * level)
            {
                x = -level;
                y = hexagonNumber - THREE * level;
            }
            else if (hexagonNumber <= FIVE * level)
            {
                x = hexagonNumber - FIVE * level;
                y = level;
            }
            else
            {
                x = hexagonNumber - FIVE * level;
                y = level - x;
            }
            Point p = new Point(x, y);
            return p;
        }
        public void Reset()
        {
            Input.Clear();
            Output.Clear();
            InputNumber = string.Empty;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void Changed([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
