import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

class Solution {
    public static List<Integer> sortList(List<Integer> unsortedList) {
        for (int i = 0; i < unsortedList.size(); i++) {
            int current = i;
            while (current > 0 && unsortedList.get(current) < unsortedList.get(current - 1)) {
                int temp = unsortedList.get(current);
                unsortedList.set(current, unsortedList.get(current - 1));
                unsortedList.set(current - 1, temp);
                current--;
            }
        }
        return unsortedList;
    }