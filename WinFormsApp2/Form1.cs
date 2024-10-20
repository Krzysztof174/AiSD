using System.Diagnostics;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
        static void InsertSort(int[] arr)
        {
            if (arr == null) return;
            int i = 1;
            while (arr.Length > i)
            {
                int j = i;
                while (arr[j] < arr[j - 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j += -1;
                    if (j == 0)
                    {
                        break;
                    }
                }
                i++;
            }
        }
        static int[] MergeAddArrays(int[] arr1, int[] arr2)
        {
            int[] addedArray = new int[arr1.Length + arr2.Length];
            int i = 0;
            int j = 0;
            while (i + j < arr1.Length + arr2.Length)
            {
                if (i == arr1.Length)
                {
                    addedArray[i + j] = arr2[j];
                    j++;
                    continue;
                }
                if (j == arr2.Length)
                {
                    addedArray[i + j] = arr1[i];
                    i++;
                    continue;
                }
                if (arr1[i] < arr2[j])
                {
                    addedArray[i + j] = arr1[i];
                    i++;
                }
                else
                {
                    addedArray[i + j] = arr2[j];
                    j++;
                }
            }

            return addedArray;
        }
        static int[] MergeSort(int[] arr)
        {
            int[] mergedArray = new int[arr.Length];
            if (arr.Length == 1)
            {
                return arr;
            }
            if (arr.Length == 2)
            {
                if (arr[0] > arr[1])
                {
                    int temp = arr[0];
                    arr[0] = arr[1];
                    arr[1] = temp;
                }
                return arr;
            }

            int[] leftSide;
            int[] rightSide;
            if (arr.Length % 2 == 0)
            {
                leftSide = new int[arr.Length / 2];
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    leftSide[i] = arr[i];
                }

                rightSide = new int[arr.Length / 2];
                for (int i = 0; i + arr.Length / 2 < arr.Length; i++)
                {
                    rightSide[i] = arr[arr.Length / 2 + i];
                }
            }
            else
            {
                leftSide = new int[(arr.Length - 1) / 2];
                for (int i = 0; i < (arr.Length - 1) / 2; i++)
                {
                    leftSide[i] = arr[i];
                }

                rightSide = new int[(arr.Length - 1) / 2 + 1];
                for (int i = 0; i + (arr.Length - 1) / 2 < arr.Length; i++)
                {
                    rightSide[i] = arr[(arr.Length - 1) / 2 + i];
                }
            }
            int[] leftMerged = MergeSort(leftSide);
            int[] rightMerged = MergeSort(rightSide);
            mergedArray = MergeAddArrays(leftMerged, rightMerged);
            return mergedArray;
        }
        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);

                QuickSort(arr, left, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, right);
            }
        }

        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];

            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;

                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp1;

            return i + 1;
        }
        static void CountingSort(int[] arr)
        {
            int max = FindMax(arr);

            int[] countArray = new int[max + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                countArray[arr[i]]++;
            }

            int index = 0;
            for (int i = 0; i < countArray.Length; i++)
            {
                while (countArray[i] > 0)
                {
                    arr[index] = i;
                    index++;
                    countArray[i]--;
                }
            }
        }
        static int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userInput = new int[textBox1.Text.Length];
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                userInput[i] = textBox1.Text[i] - '0';
            }
        }

        int[] userInput;
        int[] sortedInput;
        public int selectedSort = 1;
        void Sort()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            if (userInput == null) return;
            switch (selectedSort)
            {
                case 1:
                    sortedInput = userInput;
                    BubbleSort(sortedInput);
                    break;
                case 2:
                    sortedInput = userInput;
                    InsertSort(sortedInput);
                    break;
                case 3:
                    sortedInput = MergeSort(userInput);
                    break;
                case 4:
                    sortedInput = userInput;
                    QuickSort(sortedInput, 0, sortedInput.Length - 1);
                    break;
                case 5:
                    sortedInput = userInput;
                    CountingSort(sortedInput);
                    break;
            }
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            label1.Text = "Czas sortowania: " + elapsedTime.TotalMilliseconds + " ms";
            textBox2.Text = string.Join(", ", sortedInput);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            selectedSort = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedSort = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedSort = 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sort();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (amountOfDigits <= 0) return;
            Random random = new Random();

            int[] randomArray = new int[amountOfDigits];
            for (int i = 0; i < amountOfDigits; i++)
            {
                randomArray[i] = random.Next(0, 10);
            }
            textBox1.Text = string.Join("", randomArray);
            userInput = randomArray;
        }

        int amountOfDigits = 0;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            amountOfDigits = (int)numericUpDown1.Value;
            // How many elements
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Sorted array
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            selectedSort = 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            selectedSort = 5;
        }
    }
}
