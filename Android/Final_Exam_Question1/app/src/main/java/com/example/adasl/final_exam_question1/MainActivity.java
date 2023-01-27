package com.example.adasl.final_exam_question1;

import android.content.Context;
import android.database.sqlite.SQLiteOpenHelper;
import android.graphics.Color;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.database.sqlite.SQLiteDatabase;
import android.view.View;
import android.widget.Button;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.database.Cursor;

public class MainActivity extends AppCompatActivity {

    String [] question_library = new String [] {"下列臺鐵哪種列車不是電聯車？","下列臺鐵哪種列車不能使用電子票證搭乘？",
            "最古老的醫院是設在？","世界上第一臺坦克是哪臺？","封建制度是基於土地的授予建立了下列那一種主從關係的政治形式？",
            "下列食品中，哪個含鈣量最高？","\"只要有恆心\"的下一句是什麼？","《聊齋志異》的作者是誰？",
            "提出著名的韋達公式的數學家韋達，是哪國人？","尤西比奧是哪個國家的球星？"};

    String [][] answer = new String [][]{
            {"莒光號","太魯閣自強號","EMU500","EMU700"},
            {"普悠瑪自強號","PP自強號","EMU800","莒光號"},
            {"教堂裡","學校裡","宮廷裡","市集裡"},
            {"小威利","M1艾布蘭","CM-11勇虎式戰車","M60巴頓"},
            {"地主與農奴","祭司與貴族","貴族與平民","領主與附庸"},
            {"水果","骨頭湯","葡萄糖","奶及奶制品"},
            {"鐵柱磨成針","必定有錢剩","天下無敵人","點石可成金"},
            {"蒲松齡","曹雪芹","施耐庵","笑笑生"},
            {"法國","英國","德國","俄國"},
            {"葡萄牙","西班牙","南斯拉夫","法國"},
    };

    private Button check,next;
    private TextView question,C_and_W;
    private RadioGroup ans_group;
    private RadioButton ans1,ans2,ans3,ans4;
    int random_num = 0; //取隨機題目用

    SQLiteDatabase db1 = openOrCreateDatabase("demo.db", MODE_PRIVATE, null); //建立資料庫
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        //把資料放進資料庫，包括建立資料表及輸入資料到資料表中
        //db1.execSQL("CREATE TABLE Question(_id INTEGER PRIMARY KEY AUTOINCREMENT,data TEXT)");
        //db1.execSQL("CREATE TABLE Answer(_id INTEGER PRIMARY KEY AUTOINCREMENT,ans1 TEXT,ans2 TEXT, ans3 TEXT,ans4 TEXT)");
        data_key_in();
        //取得物件
        check = (Button)findViewById(R.id.check);
        question = (TextView)findViewById(R.id.Question);
        C_and_W = (TextView)findViewById(R.id.correct_or_wrong);
        ans_group = (RadioGroup) findViewById(R.id.ansGroup);
        ans1 = (RadioButton)findViewById(R.id.ans1);
        ans2 = (RadioButton)findViewById(R.id.ans2);
        ans3 = (RadioButton)findViewById(R.id.ans3);
        ans4 = (RadioButton)findViewById(R.id.ans4);
        //開始取題目
        getQuestion_and_answer();
        check.setOnClickListener(reply);
        next.setOnClickListener(next_question);
    }


    private void data_key_in()
    {
        for (int i = 0;i < 10;i++)
        {
            String SQL = "";

            SQL = (new StringBuilder()).append("INSERT INTO Question (_id,data) values ((SELECT last_insert_rowid())+1,")
                    .append(question_library[i]).append(")").toString();
            db1.execSQL(SQL);

            SQL = (new StringBuilder()).append("INSERT INTO Answer (_id,ans1,ans2,ans3,ans4) values ((SELECT last_insert_rowid())+1,")
                    .append(answer[i][0]).append(",").append(answer[i][1]).append(",").append(answer[i][2]).append(",")
                    .append(answer[i][3]).append(")").toString();
            db1.execSQL(SQL);
        }
    }


    private void getQuestion_and_answer()
    {
        random_num = (int)(Math.random()* 10);

        Cursor cursor = db1.query("Question",new String[] {"_id","data"},"_id = " + random_num,null,null,null,null);
        question.setText(cursor.getString(1));

        cursor = db1.query("Answer",new String[] {"_id","ans1","ans2","ans3","ans4"},"_id = " + random_num,null,null,null,null);
        ans1.setText(cursor.getString(1));
        ans2.setText(cursor.getString(2));
        ans3.setText(cursor.getString(3));
        ans4.setText(cursor.getString(4));

        cursor.close();
    }

    private Button.OnClickListener next_question = new Button.OnClickListener()
    {
        @Override
        public void onClick(View V)
        {
            getQuestion_and_answer();
        }
    };

    private Button.OnClickListener reply = new Button.OnClickListener()
    {
        @Override
        public void onClick(View V)
        {

            int option = ans_group.getCheckedRadioButtonId();

            if (option == -1)
            {
                C_and_W.setText("請選擇答案");
                C_and_W.setTextColor(Color.parseColor("#FFFF00"));
            }
            else
            {
                RadioButton selectedAnswer = (RadioButton)findViewById(option);

                if(selectedAnswer.getText().toString().equals(answer[random_num][0]))
                {
                    C_and_W.setText("正確");
                    C_and_W.setTextColor(Color.parseColor("#00FF00"));
                }
                else
                {
                    C_and_W.setText("錯誤");
                    C_and_W.setTextColor(Color.parseColor("#FF0000"));
                }
            }
        }
    };



    @Override
    protected void onDestroy() {
        super.onDestroy();
        db1.close();
    }
}
