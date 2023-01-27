package com.example.adasl.calculator;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private Button btn_zero,btn_one,btn_two,btn_three,btn_four,btn_five,btn_six,btn_seven,btn_eight,btn_nine,
            btn_dot,btn_equal,btn_plus,btn_minus,btn_multi,btn_division,btn_CE,btn_BS;
    private TextView textView;
    private String state = "",tempState = ""; //判斷加(P)減(Mi)乘(Mu)除(D)
    private double num2,total;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //取得各物件
        btn_zero = (Button)findViewById(R.id.btn_zero);
        btn_one = (Button)findViewById(R.id.btn_one);
        btn_two = (Button)findViewById(R.id.btn_two);
        btn_three = (Button)findViewById(R.id.btn_three);
        btn_four = (Button)findViewById(R.id.btn_four);
        btn_five = (Button)findViewById(R.id.btn_five);
        btn_six = (Button)findViewById(R.id.btn_six);
        btn_seven = (Button)findViewById(R.id.btn_seven);
        btn_eight = (Button)findViewById(R.id.btn_eight);
        btn_nine = (Button)findViewById(R.id.btn_nine);
        btn_dot = (Button)findViewById(R.id.btn_dot);
        btn_equal = (Button)findViewById(R.id.btn_equal);
        btn_plus = (Button)findViewById(R.id.btn_plus);
        btn_minus = (Button)findViewById(R.id.btn_minus);
        btn_multi = (Button)findViewById(R.id.btn_multi);
        btn_division = (Button)findViewById(R.id.btn_devision);
        textView = (TextView)findViewById(R.id.show);
        btn_CE = (Button)findViewById(R.id.btn_CE); //歸零
        btn_BS = (Button)findViewById(R.id.btn_BS); //移除最後一個數字

        textView.setText("0");

        //設定數字鍵事件
        btn_zero.setOnClickListener(numListener);
        btn_one.setOnClickListener(numListener);
        btn_two.setOnClickListener(numListener);
        btn_three.setOnClickListener(numListener);
        btn_four.setOnClickListener(numListener);
        btn_five.setOnClickListener(numListener);
        btn_six.setOnClickListener(numListener);
        btn_seven.setOnClickListener(numListener);
        btn_eight.setOnClickListener(numListener);
        btn_nine.setOnClickListener(numListener);
        btn_dot.setOnClickListener(numListener);

        //設定加減乘除按鍵事件
        btn_plus.setOnClickListener(operListener);
        btn_minus.setOnClickListener(operListener);
        btn_multi.setOnClickListener(operListener);
        btn_division.setOnClickListener(operListener);

        //設定等於、歸零、移除後一個數字按鈕事件
        btn_equal.setOnClickListener(equalListener);
        btn_CE.setOnClickListener(functionKeyListener);
        btn_BS.setOnClickListener(functionKeyListener);
    }

    private Button.OnClickListener numListener = new Button.OnClickListener() //數字按鈕顯示的事件
    {
        @Override
        public void onClick(View v)
        {
            checknum();
            String num = textView.getText().toString();
            switch (v.getId())
            {
                case R.id.btn_zero:
                {
                    if (!num.equals("0") || num.equals(""))
                    {
                        textView.setText(num + "0");
                    }

                    break;
                }
                case R.id.btn_one:
                    textView.setText(num + "1");
                    break;
                case R.id.btn_two:
                    textView.setText(num + "2");
                    break;
                case R.id.btn_three:
                    textView.setText(num + "3");
                    break;
                case R.id.btn_four:
                    textView.setText(num + "4");
                    break;
                case R.id.btn_five:
                    textView.setText(num + "5");
                    break;
                case R.id.btn_six:
                    textView.setText(num + "6");
                    break;
                case R.id.btn_seven:
                    textView.setText(num + "7");
                    break;
                case R.id.btn_eight:
                    textView.setText(num + "8");
                    break;
                case R.id.btn_nine:
                    textView.setText(num + "9");
                    break;
                case R.id.btn_dot:
                {
                    if(num.indexOf(".") == -1 && num.equals(""))
                    {
                        textView.setText("0.");
                    }
                    else
                    {
                        textView.setText(num + ".");
                    }
                    break;
                }
            }
        }
    };

    private Button.OnClickListener operListener = new Button.OnClickListener() //運算子按鈕事件
    {
        @Override
        public void onClick(View v)
        {

            if (!textView.getText().toString().equals("Error! 除以0! 請按CE鍵!"))
            {
                String num = textView.getText().toString();
                count(Double.parseDouble(num));
                switch (v.getId())
                {
                    case R.id.btn_plus:
                        state = "P";
                        break;
                    case R.id.btn_minus:
                        state = "Mi";
                        break;
                    case R.id.btn_multi:
                        state = "Mu";
                        break;
                    case R.id.btn_devision:
                        state = "D";
                        break;
                }
                textView.setText("0");
            }
        }
    };

    private Button.OnClickListener equalListener = new Button.OnClickListener() //等於按鈕事件
    {
        @Override
        public void onClick(View v)
        {
            num2 = Double.parseDouble(textView.getText().toString());
            count(num2);
        }
    };

    private Button.OnClickListener functionKeyListener = new Button.OnClickListener() //歸零、移除最後一個數字按鈕事件
    {
        @Override
        public void onClick(View v)
        {
            switch (v.getId())
            {
                case R.id.btn_CE:
                {
                    total = num2 = 0.0;
                    textView.setText("0");
                    state = "";
                    break;
                }
                case R.id.btn_BS:
                {
                    String num = textView.getText().toString();
                    num = num.substring(0,num.length() - 1);
                    textView.setText(num);
                    break;
                }
            }
        }
    };

    private void checknum() //檢查顯示數字是否為0
    {
        String num = textView.getText().toString();

        if (num.equals("0"))
        {
            textView.setText(""); //為0就先清空在說
        }
    }

    private void count(Double number)
    {
        if (state.equals(""))
        {
            total = number;
            return;
        }

        switch(state)
        {
            case "P":
                total += number;
                break;
            case "Mi":
                total -= number;
                break;
            case "Mu":
                total *= number;
                break;
            case "D":
            {
                if(number == 0.0)
                {
                    textView.setText("Error! 除以0! 請按CE鍵!");

                }
                else
                {
                    total /= number;
                }

                break;
            }
        }

        if (!textView.getText().toString().equals("Error! 除以0! 請按CE鍵!"))
        {
            textView.setText(Double.toString(total));
        }
    }
}

