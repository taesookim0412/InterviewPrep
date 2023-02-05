import javax.sound.midi.SysexMessage;
import java.util.ArrayList;
import java.util.Arrays;

public class ArraysExamples {
    public ArraysExamples() {
        System.out.println("ArraysExamples");
        System.out.println("Arrays");
        arrays();
        System.out.println("ArrayList");
        arrayList();
    }

    public void arrays() {
        String[] array = new String[3];
        array[0] = "Item1";
        array[1] = "Item2";
        array[2] = "Item3";

        System.out.println(Arrays.toString(array));
    }

    public void arrayList() {
        ArrayList<String> arrayList = new ArrayList<>(3);
        arrayList.add("Item1");
        arrayList.add("Item2");
        arrayList.add("Item3");

        System.out.println(String.join(" ", arrayList));

        System.out.println(arrayList.get(0));
    }


    /**
     * Can have any object wrapping array.*/
    public void arrayExamplesArray() {
        ArraysExamples[] arr = new ArraysExamples[3];
    }
}
