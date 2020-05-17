using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeSolutions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //// The complexity will be O(n) as we are iterating the array only once.
            //// The idea is to add the items to dictionary as key and the value will be the 
            //// number of occurrences of the number.
            //// Whenever the value of it gets incresed, it is the first occurrence of duplicates.
            //FindFirstDuplicateOccurrence();

            //// The complexity is again O(n) as we are iterating the array only once.
            //// The idea is same as the above.. we will add the key and count in dictionary.
            // NumberOfTimesTheItemOccurred();

            //// Max of the given array numbers;
            // IdentifyMaxNumber();

            // RemoveDuplicates();

            // Observe that its base and height are both equal to, and the image is drawn using # symbols and spaces.
            // The last line is not preceded by any spaces.
            // Write a program that prints a staircase of size.
            // PrintStaircaseFromRight(6);

            // PrintInverseStaircaseFromRight(6);

            // PrintStaircaseFromLeft(15);

            // GemStones();

            // MakeAnagrams();

            // MiniMax();

            // Grades();

            // ClimbLeaderBoard();

            // Birthday();

            //DivisibleByNumbers();

            // MigratoryBirds();

            //ShallowCopyDeepCopy();

            // QueensAttack();

            //SherlockAndSquares();

            // CavityMap();

            // Stones();

            //PickingNumbers();

            // PDFViewer();

            // HowmanyGames();

            // InsertionSort();

            // UtopianTreeHeight();

            // KaprekarNumbers();

            // SockMerchant();

            //BeautifulDays();

            // TimeInWords();

            // BirthdayGifts();

            // StrangeCounter();

            // CountingValleys();

            // CutTheSticks();

            // CatAndMouse();

            // Advertising();

            // Encryption();

            //Prisoners();

            // IndexOfIndexes();

            //JumpingOnClouds();

            // SpecialProblems();

            // ReverseArray();

            RepeatedString();

            Console.Read();
        }

        private static void RepeatedString()
        {
            int n = 10;
            string s = "a";
            List<int> total = s.Select((x, i) => (x == 'a') ? i + 1 : -1).Where(x => x > 0).ToList();
            bool breakFound = false;
            int t = 0;
            while (!breakFound)
            {
                while(t < total.Count)
                {
                    if (total[t] + s.Length <= n)
                    {
                        total.Add(total[t] + s.Length);
                    }
                    else
                    {
                        breakFound = true;
                    }
                    t++;
                }
            }
        }

        private static void ReverseArray()
        {
            int[] a = new int[] { 1, 2, 3 };
            for (int i = 0; i <= a.Length / 2; i++)
            {
                int t = a[i];
                a[i] = a[a.Length - i - 1];
                a[a.Length - i - 1] = t;
            }
        }

        private static void SpecialProblems()
        {
            int n = 5, k = 3;
            int[] arr = new int[] { 4, 2, 6, 1, 10 };
            Dictionary<int, int[]> dict = new Dictionary<int, int[]>();
            int page = 1;
            for (int chapter = 0; chapter < n; chapter++)
            {
                for (int p = 0; p < arr[chapter]; p += k)
                {
                    List<int> ints = new List<int>();
                    for (int d = p + 1; d <= p + k && d <= arr[chapter]; d++)
                    {
                        ints.Add(d);
                    }
                    dict.Add(page, ints.ToArray());
                    page++;
                }
            }

            int sum = 0;
            foreach (KeyValuePair<int, int[]> kvp in dict)
            {
                sum = (kvp.Value.Contains(kvp.Key)) ? sum + 1 : sum;
            }
        }

        private static void JumpingOnClouds()
        {
            int[] c = new int[] { 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1 };
            int i = 0, k = 19;
            int next = i + k;
            int power = 100;
            while (true)
            {
                if (next >= c.Length)
                {
                    next %= c.Length;
                }
                power = (c[next] == 1) ? power -= 3 : power -= 1;
                if (next == i)
                {
                    break;
                }
                next += k;
                if (next >= c.Length)
                {
                    next %= c.Length;
                }
            }
        }

        private static void IndexOfIndexes()
        {
            int[] p = new int[] { 4, 3, 5, 1, 2 };
            int[] arr = new int[p.Length];
            for (int i = 0; i < p.Length; i++)
            {
                arr[i] = p.ToList().IndexOf(p.ToList().IndexOf(i + 1) + 1) + 1;
            }
        }

        private static void Prisoners()
        {
            List<int[]> list = new List<int[]>();
            foreach (int[] i in list)
            {
                int n = i[0], m = i[1], s = i[2];
                //Console.WriteLine("*****************************");
                //Console.WriteLine("n: " + n + "; m: " + m + "; s: " + s);
                int rem = m % n;
                //Console.WriteLine("reminder: " + rem);
                //Console.WriteLine("Answer: " + (s + rem - 1).ToString());
                Console.WriteLine(s + rem - 1);
            }
        }

        private static void Encryption()
        {
            string s = "chillout";
            s = s.Replace(" ", "");
            double root = Math.Sqrt(s.Length);
            int rows = (int)Math.Ceiling(root);
            int cols = (int)Math.Floor(root);
            cols = (rows * cols < s.Length) ? cols + 1 : cols;
            string str = string.Empty;
            for (int i = 0; i < rows; i++)
            {
                int idx = i;
                for (int j = 0; j < cols; j++)
                {
                    if (idx < s.Length)
                    {
                        str += (s[idx]);
                    }
                    else
                    {
                        str += " ";
                    }

                    idx += rows;
                }
                str = str.TrimEnd() + " ";
            }
            Console.Write(str.TrimEnd());
        }

        private static void Advertising()
        {
            int sum = 0, n = 3;
            int userCount = 5;
            for (int i = 0; i < n; i++)
            {
                userCount = (int)Math.Floor((decimal)userCount / 2);
                sum += userCount;
                userCount *= 3;
            }
        }

        private static void CatAndMouse()
        {
            int x = 1, y = 3, z = 2;
            string ret = string.Empty;
            if (x == z && y == z)
            {
                ret = "Mouse C";
            }
            else if (x == z)
            {
                ret = "Cat A";
            }
            else if (y == z)
            {
                ret = "Cat B";
            }
            while (!(x == z || y == z))
            {
                x = (x > z) ? x - 1 : x + 1;
                y = (y > z) ? y - 1 : y + 1;
                if (x == z && y == z)
                {
                    ret = "Mouse C";
                }
                else if (x == z)
                {
                    ret = "Cat A";
                }
                else if (y == z)
                {
                    ret = "Cat B";
                }
            }
            Console.Write(ret);
        }

        private static void CutTheSticks()
        {
            int[] arr = new int[] { 5, 4, 4, 2, 2, 8 };
            int min = 0;
            List<int> data = new List<int>
            {
                arr.Length
            };
            while (arr.Count() > 0)
            {
                min = arr.Min();
                arr = arr.Select(x => x - min).Where(x => x > 0).ToArray();
                if (arr.Count() > 0)
                {
                    data.Add(arr.Count());
                }
            }
        }

        private static void CountingValleys()
        {
            string s = "DDUUDDUDUUUD";
            int circles = 0;
            bool downStarted = false;
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                count = (s[i] == 'D') ? count - 1 : count + 1;
                if (count == -1)
                {
                    downStarted = true;
                }
                if (count == 0 && downStarted)
                {
                    downStarted = false;
                    circles++;
                }
            }
        }

        private static void StrangeCounter()
        {
            int t = 4;
            int counter = 3;
            int timer = 0;
            bool found = false;
            while (true)
            {
                for (int i = counter; i >= 1; i--)
                {
                    timer++;
                    if (timer == t)
                    {
                        Console.Write(i);
                        found = true;
                        break;
                    }
                }
                counter *= 2;
                if (found)
                {
                    break;
                }
            }
        }

        private static void BirthdayGifts()
        {
            int b = 27984, w = 1402, bc = 619246, wc = 615589, z = 247954;
            long[] longs = new long[3];
            longs[0] = (b * bc) + (w * wc);
            longs[1] = (((b + w) * bc) + (w * z));
            longs[2] = (((b + w) * wc) + (b * z));

            Console.WriteLine(longs.Min());
        }

        private static void TimeInWords()
        {
            int h = 12;
            int m = 35;
            string inWords = string.Empty;
            string toOrPast = (m > 30 ? "to" : "past");
            string[] hours = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve" };
            string[] minutes = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty", "Twenty one", "Twenty two", "Twenty three", "Twenty four", "Twenty Five", "Twenty Six", "Twenty Seven", "Twenty Eight", "Twenty Nine", "Thirty" };
            if (m == 0)
            {
                inWords = hours[h].ToString() + " o' clock";
            }
            else if (m > 30)
            {
                if (h == 12)
                {
                    h = 0;
                }

                inWords = minutes[60 - m].ToString() + " minuites to " + hours[h + 1].ToString();
            }
            else
            {
                inWords = minutes[m].ToString() + " minuites past " + hours[h].ToString();
            }

            Console.WriteLine(inWords.ToLower());
        }

        private static void BeautifulDays()
        {
            int i = 20, j = 23, k = 6;
            int count = 0;
            for (int a = i; a <= j; a++)
            {
                if ((a - Convert.ToInt32(new string(a.ToString().Reverse().ToArray()))) % k == 0)
                {
                    count++;
                }
            }
        }

        private static void SockMerchant()
        {
            int[] ar = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            List<IGrouping<int, int>> grp = ar.GroupBy(x => x).ToList();
            int count = 0;
            foreach (IGrouping<int, int> x in grp)
            {
                count += x.Count() / 2;
            }
            Console.WriteLine(count);
        }

        private static void KaprekarNumbers()
        {
            int p = 1, q = 100;
            List<int> list = new List<int>();
            for (int i = p; i <= q; i++)
            {
                int square = i * i;
                string r = square.ToString().Substring(square.ToString().Length - i.ToString().Length);
                string d = string.Empty;
                if (square.ToString().TrimEnd(r.ToString().ToCharArray()) != string.Empty)
                {
                    d = square.ToString().TrimEnd(r.ToCharArray());
                }

                if (Convert.ToInt32(r) + Convert.ToInt32(d) == i)
                {
                    list.Add(i);
                }
            }
            for (int a = 0; a < list.Count; a++)
            {
                Console.Write(list[a].ToString());
                if (a != list.Count - 1)
                {
                    Console.Write(" ");
                }
            }
        }

        private static void UtopianTreeHeight()
        {
            int n = 5;
            int h = 1;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 1)
                    {
                        h *= 2;
                    }
                    else
                    {
                        h += 1;
                    }
                }
            }

            Console.WriteLine(h);
        }

        private static void InsertionSort()
        {
            int[] arr = new int[] { 2, 4, 6, 8, 3 };
            int lastValue = arr[arr.Length - 1];
            bool lastValueFoundPlace = false;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (i > 0)
                {
                    if (arr[i] < arr[i - 1] || (arr[i] > lastValue && arr[i - 1] > lastValue))
                    {
                        arr[i] = arr[i - 1];
                    }
                    else
                    {
                        lastValueFoundPlace = true;
                        arr[i] = lastValue;
                        break;
                    }
                }
                else if (i == 0 && !lastValueFoundPlace)
                {
                    arr[0] = lastValue;
                }

                string str1 = string.Empty;
                foreach (int latest in arr)
                {
                    str1 += latest.ToString() + " ";
                }
                Console.WriteLine(str1.TrimEnd());
            }

            string str = string.Empty;
            foreach (int latest in arr)
            {
                str += latest.ToString() + " ";
            }
            Console.WriteLine(str.TrimEnd());
        }

        private static void HowmanyGames()
        {
            int p = 20, d = 3, m = 6, s = 85;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int index = 0;
            int sum = 0;
            int price = 0;
            while (sum < s)
            {
                price = (p - (index * d)) < m ? m : (p - (index * d));
                if (sum + price < s)
                {
                    dict.Add(index + 1, price);
                    sum += price;
                    index++;
                }
                else
                {
                    break;
                }
            };
            Console.WriteLine(index);
        }

        private static void PDFViewer()
        {
            string word = "zaba";
            string[] letters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            char[] wordArray = word.ToArray();
            int max = 0;
            foreach (char s in wordArray)
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (s.ToString() == letters[i])
                    {
                        max = i > max ? i : max;
                    }
                }
            }

            Console.WriteLine(max * 1 * word.Length);
        }

        private static void PickingNumbers()
        {
            int[] a = new int[] { 1, 2, 2, 3, 1, 2 };
            List<int[]> finalList = new List<int[]>();
            a.ToList().Sort();
            foreach (int x in a)
            {
                int[] list = a.Where(p => (x - p) <= 1 && (x - p) > -1).Select(p => p).ToArray();
                finalList.Add(list);
            }

            Console.WriteLine(finalList.Select(x => x.Length).Max());
        }

        private static void Stones()
        {
            int n = 7, a = 9, b = 11;
            List<int> arr = new List<int>();
            int iterationsOfA = n - 1;
            int iterationsOfB = 0;
            for (int j = 0; j < n; j++, iterationsOfA--, iterationsOfB++)
            {
                arr.Add(iterationsOfA * a + iterationsOfB * b);
            }

            iterationsOfA = 0;
            iterationsOfB = n - 1;
            for (int j = 0; j < n; j++, iterationsOfA++, iterationsOfB--)
            {
                arr.Add(iterationsOfA * a + iterationsOfB * b);
            }
        }

        private static void CavityMap()
        {
            string[] grid = { "1112", "1912", "1892", "1234" };
            for (int i = 1; i < grid.Length - 1; i++)
            {
                string prevString = grid[i - 1];
                //int[] prevInts = prevString.Select(x => Convert.ToInt32(x.ToString())).ToArray();

                string currentString = grid[i];
                //int[] currentInts = currentString.Select(x => Convert.ToInt32(x.ToString())).ToArray();

                string nextString = grid[i + 1];
                //int[] nextInts = nextString.Select(x => Convert.ToInt32(x.ToString())).ToArray();

                for (int j = 1; j < currentString.Length - 1; j++)
                {
                    int currentInt = Convert.ToInt32(currentString[j].ToString());
                    int up = (prevString[j] != 'X') ? Convert.ToInt32(prevString[j].ToString()) : currentInt;
                    int down = Convert.ToInt32(nextString[j].ToString());
                    int left = (currentString[j - 1] != 'X') ? Convert.ToInt32(currentString[j - 1].ToString()) : currentInt;
                    int right = Convert.ToInt32(currentString[j + 1].ToString());
                    if (currentInt > up && currentInt > down && currentInt > left && currentInt > right)
                    {
                        char[] temp = currentString.ToCharArray();
                        temp[j] = 'X';
                        currentString = new string(temp);
                    }
                }
                grid[i] = currentString;
            }

            //return grid;
        }

        private static void SherlockAndSquares()
        {
            int a = 100, b = 1000;
            int count = 0;
            int d = (int)Math.Sqrt(a);
            for (int i = d; i < b; i++)
            {
                if (i * i <= b && i * i >= a)
                {
                    count++;
                }
                else if (i * i > b)
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }

        private static void QueensAttack()
        {
            int n = 4; // 4X4 board;
            int r_q = 4; // row;
            int c_q = 4; // column;
            //int[][] obstacles = new int[][] { new int[] { 3, 5 } };
            //int[][] obstacles = new int[][] { new int[] { 5, 5 }, new int[] { 4, 2 }, new int[] { 2, 3 } };
            int k = 0;
            int[][] obstacles = new int[k][];

            int left = c_q - 1;
            int right = n - c_q;
            int up = n - r_q;
            int down = r_q - 1;
            int upleft = (up >= left) ? left : up;
            int upright = (up >= right) ? right : up;
            int downleft = (down >= left) ? left : down;
            int downright = (down >= right) ? right : down;

            foreach (int[] obst in obstacles)
            {
                int row = obst[0], col = obst[1];
                if (row == r_q && col < c_q)
                {
                    if (c_q - col - 1 < left)
                    {
                        left = c_q - col - 1;
                    }
                }
                else if (row == r_q && col > c_q)
                {
                    if (col - c_q - 1 < right)
                    {
                        right = col - c_q - 1;
                    }
                }

                else if (row > r_q && col == c_q)
                {
                    if (row - r_q - 1 < up)
                    {
                        up = row - r_q - 1;
                    }
                }
                else if (row < r_q && col == c_q)
                {
                    if (r_q - row - 1 < down)
                    {
                        down = r_q - row - 1;
                    }
                }
                else if (row > r_q && col < c_q)
                {
                    if (row - r_q == c_q - col)
                    {
                        if (row - r_q - 1 < upleft)
                        {
                            upleft = row - r_q - 1;
                        }
                    }
                }
                else if (row > r_q && col > c_q)
                {
                    if (row - r_q == col - c_q)
                    {
                        if (row - r_q - 1 < upright)
                        {
                            upright = row - r_q - 1;
                        }
                    }
                }
                else if (row < r_q && col < c_q)
                {
                    if (r_q - row == c_q - col)
                    {
                        if (r_q - row - 1 < downleft)
                        {
                            downleft = r_q - row - 1;
                        }
                    }
                }
                else if (row < r_q && col > c_q)
                {
                    if (r_q - row == col - c_q)
                    {
                        if (r_q - row - 1 < downright)
                        {
                            downright = r_q - row - 1;
                        }
                    }
                }
            }

            int moves = left + right + up + down + upleft + upright + downleft + downright;
        }

        private static void MigratoryBirds()
        {
            List<int> arr = new List<int>() { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };
            arr.Sort();
            var result = arr.GroupBy(x => x).Select(x => new { key = x.Key, value = x.Count() }).ToList();
            int data = result.FindAll(x => x.value == result.Max(y => y.value)).Min(z => z.key);

        }

        private static void DivisibleByNumbers()
        {
            int[] ar = new int[] { 1, 3, 2, 6, 1, 2 };
            int n = 6, k = 3;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        private static void Birthday()
        {
            int[] s = { 4 };
            int d = 4;
            int m = 1;
            int count = 0;
            for (int i = 0; i <= s.Length - m; i++)
            {
                int[] intSet = s.Skip(i).Take(m).ToArray();
                if (intSet.Sum() == d)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        private static void ShallowCopyDeepCopy()
        {
            // Showing different values.
            string[] a = new string[] { "1", "2", "3" };
            string[] b = a.Clone() as string[];
            a[0] = "0";
            Console.WriteLine("b[0]: " + b[0]);
            Console.WriteLine("a[0]: " + a[0]);

            Sample s = new Sample() { index = 0, Name = "a" };
            Sample t = s;
        }

        private static void ClimbLeaderBoard()
        {
            int[] scores = { 100, 100, 50, 40, 40, 20, 10 };
            int[] alice = { 5, 25, 50, 120 };

            IEnumerable<int> result = scores.Select(s => (scores: s, isPerson: false))

            // convert persons score to a tuple and concat
            .Concat(alice.Select(s => (scores: s, isPerson: true)))

            // Group by scores
            .GroupBy(x => x.scores)

            // order by score
            .OrderBy(x => x.Key)

            // select into an indexable tuple so we know everyones rank
            .Select((groups, i) => (rank: i, groups))

            // Filter the person
            .Where(x => x.groups.Any(y => y.isPerson))

            // select the rank
            .Select(x => x.rank);
        }

        private static void Grades()
        {
            List<int> finalGrades = new List<int>();
            foreach (int x in finalGrades)
            {
                if (x > 37 && canBeRounded(x))
                {
                    finalGrades.Add((int)Math.Ceiling((decimal)(x / 5) * 5));
                }
                else
                {
                    finalGrades.Add(x);
                }
            }
            foreach (int x in finalGrades)
            {
                Console.WriteLine(x);
            }
        }

        public static bool canBeRounded(int n)
        {
            return n % 5 == 0 || (n + 1) % 5 == 0 || (n + 2) % 5 == 0;
        }

        private static void MiniMax()
        {
            long[] arr = { 256741038, 623958417, 467905213, 714532089, 938071625 };
            Array.Sort(arr);
            long min = 0;
            long max = 0;
            for (long i = 0; i < arr.Length; i++)
            {
                if (i < 4)
                {
                    min += arr[i];
                }

                if (i > 0)
                {
                    max += arr[i];
                }
            }

            Console.WriteLine(min.ToString() + " " + max.ToString());
        }

        private static void MakeAnagrams()
        {
            string s1 = "absdjkvuahdakejfnfauhdsaavasdlkj";
            string s2 = "djfladfhiawasdkjvalskufhafablsdkashlahdfa";
            int count = 0;
            foreach (char x in s1.ToCharArray())
            {
                if (!s2.Contains(x.ToString()))
                {
                    count++;
                }
            }
        }

        private static void GemStones()
        {
            string[] arr = { "basdfj", "asdlkjfdjsa", "bnafvfnsd", "oafhdlasd" };
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string sample = arr[0];
            foreach (char x in sample.ToCharArray())
            {
                dict[x.ToString()] = 1;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i].Contains(x.ToString()))
                    {
                        dict[x.ToString()]++;
                    }
                }
            }
            int result = 0;
            foreach (int item in dict.Values)
            {
                if (item == arr.Length)
                {
                    result++;
                }
            }

            Console.Write(result);
        }

        private static void PrintStaircaseFromLeft(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int count = n;
                do
                {
                    if (count < i + 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    count--;
                } while (count > 0);
                Console.WriteLine();
            }
        }

        private static void PrintInverseStaircaseFromRight(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int count = n;
                do
                {
                    Console.Write("*");
                    count--;
                } while (i < count);

                if (count < n - 1)
                {
                    Console.WriteLine();
                }
            }
        }

        private static void PrintStaircaseFromRight(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                do
                {
                    Console.Write("*");
                    count++;
                } while (i >= count);

                if (count != n)
                {
                    Console.WriteLine();
                }
            }
        }

        private static void RemoveDuplicates()
        {
            int[] array = { 10, 5, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            List<int> result = new List<int>();
            foreach (int x in array)
            {
                if (!result.Contains(x))
                {
                    result.Add(x);
                }
            }

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }

        private static void IdentifyMaxNumber()
        {
            int[] array = { 10, 5, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            int max = 0;
            foreach (int a in array)
            {
                max = a > max ? a : max;
            }

            Console.WriteLine(max);
        }

        private static void NumberOfTimesTheItemOccurred()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] array = { 10, 5, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            foreach (int item in array)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }

            foreach (KeyValuePair<int, int> item in dict)
            {
                Console.WriteLine("item " + item.Key + " occurred " + item.Value + " times.");
            }

            List<int> result = dict.Where(x => x.Value > 1).Select(x => x.Key).ToList();
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }

        private static void FindFirstDuplicateOccurrence()
        {
            int[] array = { 10, 5, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int value in array)
            {
                if (dict.ContainsKey(value))
                {
                    Console.WriteLine("First occurrence of duplicate: " + value);
                    break;
                }
                else
                {
                    dict[value] = 1;
                }
            }
        }
    }
}
