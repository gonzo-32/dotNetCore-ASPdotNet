using System;

namespace SortedorNotSortedList
{
    class Program
    {
        static int ordered_ascending(int[] arr, int length){
            if(length==1 || length==0){
                return 1;
            }

            if(arr[length-1] < arr[length-2]){
                return 0;
            }

            return ordered_ascending(arr, length - 1);
        }
        static int ordered_descending(int[] arr, int length){
            if(length==1 || length==0){
                return 1;
            }

            if(arr[length-1] > arr[length-2]){
                return 0;
            }

            return ordered_descending(arr, length - 1);
        }

        static void Main(string[] args)
        {
            while(true){
                Console.WriteLine("Enter List:");

                string res = Console.ReadLine();

                string[] stringList = res.Split(' ');

                int[] usersList = Array.ConvertAll(stringList, s => int.Parse(s));
                
                int listLength = usersList.Length;

                if(ordered_ascending(usersList, listLength) == 1 || ordered_descending(usersList, listLength) == 1){
                    Console.WriteLine("Ordered\n");
                }
                else if(ordered_ascending(usersList, listLength) == 0 || ordered_descending(usersList, listLength) == 0){
                    Console.WriteLine("Unordered List\n");
                } 
            }
            
        }
    }
}
