// --------------------------------------------------------------------------------
// Created by Ulysses Carlos on 03/23/2021 at 12:20 AM
// 
// PracticeList.cs
// It's a gimped version of std::vector.
// --------------------------------------------------------------------------------



namespace Chapter26 {
    public class PracticeList<T> {
        private T[] items;
        public long size { get; private set; } = 0;
        public long space { get; private set; } = 0;
        
        public PracticeList() {
            items = new T[0];
        }

        public T at(int index) {
            return items[index];
        }

        public void clear() {
            size = space = 0;
            items = null;
        }
        public void push_back(T item) {
            if (size == 0) {
                // Reserve some space:
                space = 8;
                items = new T[space];
                items[size++] = item;
            }
            else if (size == space) {
                // Double the size of the array, and copy.
                T[] temp = new T[space * 2];
                for (long i = 0; i < items.LongLength; i++)
                    temp[i] = items[i];
                temp[size] = item;
                
                items = temp;
                space *= 2;
                size++;
                
            }
            else {
                items[size++] = item;
            }
            // If the space is full, allocate double the size, copy the contents
            // of the old array, and then increment the size.
        }
        
    }
}