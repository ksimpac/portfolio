package com.example.adasl.homework1;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.CheckedTextView;
import android.widget.ListView;
import android.widget.TextView;
import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    private int total;
    String[] fruit = new String[]{"香蕉","西瓜","梨子","水蜜桃"};
    int[] price = new int[]{35,100,25,150};
    ArrayList<String> selectedItems = new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ListView fruit_list = (ListView)findViewById(R.id.fruit_list);
        fruit_list.setChoiceMode(ListView.CHOICE_MODE_MULTIPLE); //設定ListView多選
        ArrayAdapter<String> adapter = new ArrayAdapter<>(this,R.layout.rowlayout,R.id.lst_checkbox,fruit);
        fruit_list.setAdapter(adapter);

        //選取時把使用者選到的東西放在ArrayList
        fruit_list.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                //CheckBoxView Action

                CheckedTextView lst_checkbox = (CheckedTextView)view.findViewById(R.id.lst_checkbox);
                lst_checkbox.setChecked(!lst_checkbox.isChecked());

                //選取時把使用者選到的東西放在ArrayList跟更改上方標題列
                String selectedItem = parent.getItemAtPosition(position).toString();
                setTitle(selectedItem + " 每斤：" + Integer.toString(price[java.util.Arrays.asList(fruit).indexOf(selectedItem)]));

                if (selectedItems.contains(selectedItem))
                {
                    total -= price[java.util.Arrays.asList(fruit).indexOf(selectedItem)];
                    selectedItems.remove(selectedItem);
                }
                else
                {
                    total += price[java.util.Arrays.asList(fruit).indexOf(selectedItem)];
                    selectedItems.add(selectedItem);
                }
            }
        });

        //按下Button會做的事(顯示ArrayList的內容跟總額)
        Button cart = (Button)findViewById(R.id.btn_1);
        cart.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                String result = "";

                for(String selectedItem:selectedItems)
                {
                    result += selectedItem + " ";
                }

                result = "選購了:" + result;

                TextView buy_item = (TextView)findViewById(R.id.buy_item);
                buy_item.setText(result);

                TextView total_txt = (TextView)findViewById(R.id.total);
                total_txt.setText(Integer.toString(total));
            }
        });

        /*
        CheckedTextView lst_checkbox = (CheckedTextView)findViewById(R.id.lst_checkbox);
        lst_checkbox.setChecked(true);
        lst_checkbox.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                lst_checkbox.toggle();
            }
        });
       */
    }

}
