using System;

namespace Pagination_helper
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] itemArray = new int[15];
            int ItemOnPage = 4;

            int page = 3;

            int item = 12;


            PaginationHelper pg = new PaginationHelper(itemArray, ItemOnPage);


            int arrayLength = pg.getItemArrayLength();
            Console.WriteLine($"Количество элементов массива данных: {arrayLength}");

            int totalPages = pg.getTotalPages();
            Console.WriteLine($"Количество доступных страниц: {totalPages}");

            int totalItemOnPage = pg.getTotalItemOnPage(page);
            Console.WriteLine($"На странице {page} находится {totalItemOnPage} элементов");

            int pageByItemIndex = pg.findPageByItemIndex(item);
            Console.WriteLine($"Элемент с индексом {item} находится на странице {pageByItemIndex}");
        }
    }


    public class PaginationHelper
    {


        int[] itemArray;
        int totalItemOnPage;
        public PaginationHelper(int[] itemArray, int totalItemOnPage)
        {
            this.itemArray = itemArray;
            this.totalItemOnPage = totalItemOnPage;
        
        }


        public int getItemArrayLength()
        {
            return this.itemArray.Length;
        }

        public int getTotalPages()
        { 
            
            return (int)Math.Ceiling((double)getItemArrayLength() / totalItemOnPage);
        }

        public int getTotalItemOnPage(int page)
        {

            int totalItemOnPage = 0;
            if (page == getTotalPages()-1)
            {
                totalItemOnPage = getItemArrayLength() - (this.totalItemOnPage * (getTotalPages()-1));

            }
            else
            if (page >= 0 && page < getTotalPages())
            {
                totalItemOnPage = this.totalItemOnPage;
            }

            return totalItemOnPage;
        }


        public int findPageByItemIndex(int itemIndex)
        {

            int page = 0;

            int k = 0;

            int[] pageIndexArray = new int[getItemArrayLength()];
            if (itemIndex >= 0 && itemIndex <= getItemArrayLength() - 1)
            {
                for (int i = 0; i < getTotalPages(); i++)
                {
                    for (int j = 0; j < getTotalItemOnPage(i); j++)
                    {
                        pageIndexArray[k] = i;
                        k = k + 1;
                    }
                }

                page = pageIndexArray[itemIndex];
                
                
            }
            else
            {
            
                Console.WriteLine("Такой элемент не найден");
            }
            
            
            
            return page;
        }


    }
}
