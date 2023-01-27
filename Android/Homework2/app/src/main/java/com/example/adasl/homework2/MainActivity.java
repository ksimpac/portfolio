package com.example.adasl.homework2;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;
import android.widget.Button;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    int index = 0;
    ImageView iv = null;
    int[] imgs = {R.drawable.img01,R.drawable.img02,R.drawable.img03,R.drawable.img04
            ,R.drawable.img05,R.drawable.img06};
    String[] booknum = new String[] {
            "AEL011200","AEL011300","AEL011400",
            "ACL027100","ICL027400","ICL030131"};
    String[] bookname = new String[] {
            "Visual C# 2010程式設計速學對策","Visual Basic 2010 程式設計速學對策",
            "ASP.NET 4.0 網頁程式設計速學對策(使用C#)","戰Visual Basic 2008程式設計樂活學",
            "挑戰visual C# 2008程式設計樂活學","挑戰visual C++ 2008程式設計樂活學"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        //按鈕按下去的動作
        Button next_btn = (Button)findViewById(R.id.next_btn);
        iv = (ImageView)findViewById(R.id.iv);
        iv.setImageResource(imgs[index]); //初始化圖片

        next_btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                if(index < 5)
                {
                    index++;
                }
                else
                {
                    index = 0;
                }
                iv.setImageResource(imgs[index]);
            }

        });

        //設定長按事件
        iv.setOnLongClickListener(new View.OnLongClickListener() {
            @Override
            public boolean onLongClick(View v) {
                Toast.makeText(MainActivity.this,
                        "書號:" + booknum[index] + "\n" + "書名:" + bookname[index]
                                ,Toast.LENGTH_LONG).show();
                return false;
            }
        });

    }
}
