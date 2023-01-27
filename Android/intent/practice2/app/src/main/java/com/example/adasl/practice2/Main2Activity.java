package com.example.adasl.practice2;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class Main2Activity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.page2);
        final Intent intent = getIntent();
        setTitle("Second Page");
        Button rtn = (Button)findViewById(R.id.btn_rtn);
        TextView show_result = (TextView)findViewById(R.id.show_result);
        Bundle bundle = intent.getExtras();

        show_result.setText(bundle.getString("num1") + " + " +bundle.getString("num2") + " = " + bundle.getInt("total"));

        rtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                intent.setClass(Main2Activity.this,MainActivity.class);
                startActivity(intent);
                setContentView(R.layout.activity_main);
                Main2Activity.this.finish();
            }
        });
    }
}
