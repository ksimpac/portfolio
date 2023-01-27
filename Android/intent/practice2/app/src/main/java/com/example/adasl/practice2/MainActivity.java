package com.example.adasl.practice2;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {
    Intent intent = new Intent();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        setTitle("First Page");
        Button Next = (Button)findViewById(R.id.btn_next);
        Next.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                EditText et1 = (EditText)findViewById(R.id.et1);
                EditText et2 = (EditText)findViewById(R.id.et2);
                String num1,num2;

                num1 = et1.getText().toString();
                num2 = et2.getText().toString();
                int total = Integer.parseInt(num1) + Integer.parseInt(num2);

                Bundle bundle = new Bundle();
                bundle.putString("num1",num1);
                bundle.putString("num2",num2);
                bundle.putInt("total",total);

                intent.putExtras(bundle);
                intent.setClass(MainActivity.this,Main2Activity.class);
                startActivity(intent);
                setContentView(R.layout.page2);
                MainActivity.this.finish();
            }
        });
    }
}
