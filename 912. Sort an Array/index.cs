// Mais Eficiente

public class Solution {
    public int[] SortArray(int[] nums) {
        Array.Sort(nums);
        return nums;
    }
}

//Quick Sort

public class Solution {
    public int[] SortArray(int[] nums) {
        return QuickSort(nums, 0, nums.Length - 1);
    }

    private int[] QuickSort(int[] nums, int init, int end) {
        if (init < end) {
            int piv = Partition(nums, init, end);
            QuickSort(nums, init, piv - 1);
            QuickSort(nums, piv + 1, end);
        }

        return nums;
    }

    private int Partition(int[] nums, int init, int end) {
        int pivot = nums[end];
        int i = init;

        for (int j = init; j < end; j++) {
            if (nums[j] < pivot) {
                int temp = nums[j];
                nums[j] = nums[i];
                nums[i] = temp;
                i++;
            }
        }

        int temp2 = nums[i];
        nums[i] = nums[end];
        nums[end] = temp2;

        return i;
    }
}

// Merge Sort

public class Solution {
    public int[] SortArray(int[] nums) {
        int length = nums.Length;
        int[] temp = new int[length];
        MergeSortRecursive(nums, temp, 0, length - 1);
        return nums;
    }
    
    static void MergeSortRecursive(int[] array, int[] temp, int low, int high)
    {
        if (low < high)
        {
            int middle = (low + high) / 2;

            MergeSortRecursive(array, temp, low, middle);
            MergeSortRecursive(array, temp, middle + 1, high);

            Merge(array, temp, low, middle, high);
        }
    }

    static void Merge(int[] array, int[] temp, int low, int middle, int high)
    {
        for (int n = low; n <= high; n++)
        {
            temp[n] = array[n];
        }

        int i = low;
        int j = middle + 1;
        int k = low;

        while (i <= middle && j <= high)
        {
            if (temp[i] <= temp[j])
            {
                array[k++] = temp[i++];
            }
            else
            {
                array[k++] = temp[j++];
            }
        }

        while (i <= middle)
        {
            array[k++] = temp[i++];
        }
    }
}