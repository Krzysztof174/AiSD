namespace ConsoleApp1
{
    internal class Program
    {
        class Node
        {
            public char Character { get; set; }
            public int Frequency { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public bool IsLeaf => Left == null && Right == null;
        }

        static Node BuildHuffmanTree(Dictionary<char, int> frequencies)
        {
            var priorityQueue = new PriorityQueue<Node, int>();

            foreach (var kvp in frequencies)
            {
                priorityQueue.Enqueue(new Node { Character = kvp.Key, Frequency = kvp.Value }, kvp.Value);
            }

            while (priorityQueue.Count > 1)
            {
                var left = priorityQueue.Dequeue();
                var right = priorityQueue.Dequeue();
                var newNode = new Node
                {
                    Character = '\0',
                    Frequency = left.Frequency + right.Frequency,
                    Left = left,
                    Right = right
                };
                priorityQueue.Enqueue(newNode, newNode.Frequency);
            }

            return priorityQueue.Dequeue();
        }

        static void GenerateHuffmanCodes(Node root, string code, Dictionary<char, string> huffmanCodes)
        {
            if (root == null) return;

            if (root.IsLeaf)
            {
                huffmanCodes[root.Character] = code;
            }

            GenerateHuffmanCodes(root.Left, code + "0", huffmanCodes);
            GenerateHuffmanCodes(root.Right, code + "1", huffmanCodes);
        }

        static string Encode(string text, Dictionary<char, string> huffmanCodes)
        {
            var encodedText = string.Empty;
            foreach (var character in text)
            {
                encodedText += huffmanCodes[character];
            }
            return encodedText;
        }

        static string Decode(string encodedText, Node root)
        {
            var decodedText = string.Empty;
            var currentNode = root;
            foreach (var bit in encodedText)
            {
                currentNode = bit == '0' ? currentNode.Left : currentNode.Right;

                if (currentNode.IsLeaf)
                {
                    decodedText += currentNode.Character;
                    currentNode = root;
                }
            }
            return decodedText;
        }

        static void NWP(int[] ciag1, int[] ciag2)
        {
            int[,] tab = new int[ciag1.Length, ciag2.Length];

            for (int j = 0; j < ciag1.Length; j++)
            {
                tab[0, j] = 0;
            }
            for (int j = 0; j < ciag2.Length; j++)
            {
                tab[j, 0] = 0;
            }

            for (int i = 1; i < ciag1.Length; i++)
            {
                for (int j = 1; j < ciag2.Length; j++)
                {
                    if (ciag1[i] == ciag2[j])
                    {
                        tab[i, j] = tab[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        if (tab[i - 1, j] > tab[i, j - 1])
                        {
                            tab[i, j] = tab[i - 1, j];
                        }
                        else
                        {
                            tab[i, j] = tab[i, j - 1];
                        }
                    }
                }
            }
            for (int i = 0; i < ciag1.Length; i++)
            {
                for (int j = 0; j < ciag2.Length; j++)
                {
                    Console.WriteLine(tab[i, j]);
                }
            }
        }

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter a string to encode:");
            var input = Console.ReadLine();

            var frequencies = input.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

            var root = BuildHuffmanTree(frequencies);

            var huffmanCodes = new Dictionary<char, string>();
            GenerateHuffmanCodes(root, string.Empty, huffmanCodes);

            Console.WriteLine("Huffman Codes:");
            foreach (var kvp in huffmanCodes)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            var encodedText = Encode(input, huffmanCodes);
            Console.WriteLine($"Encoded Text: {encodedText}");

            var decodedText = Decode(encodedText, root);
            Console.WriteLine($"Decoded Text: {decodedText}");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            */
            int[] tab1 = new int[4];
            int[] tab2 = new int[4];

            for (int j = 0; j < 3; j++)
            {
                tab1[j] = j;
            }
            for (int j = 0; j < 2; j++)
            {
                tab2[j] = j;
            }
            tab2[2] = 5;

            NWP(tab1, tab2);
        }
    }
}
