//O(n^2)
// This algorithm is not stable because an earlier element can jump after an element 
// of the the same value during a swap, but the algorithm is in place as it only needs additional 
// memory to store the index to the minimum element.

class Solution {
    public static List<Integer> sortList(List<Integer> unsortedList) {
        int n = unsortedList.size();
        for (int i = 0; i < n; i++) {
            int minIndex = i;
            for (int j = i; j < n; j++) {
                if (unsortedList.get(j) < unsortedList.get(minIndex)) {
                    minIndex = j;
                }
            }
            int temp = unsortedList.get(i);
            unsortedList.set(i, unsortedList.get(minIndex));
            unsortedList.set(minIndex, temp);
        }
        return unsortedList;
    }