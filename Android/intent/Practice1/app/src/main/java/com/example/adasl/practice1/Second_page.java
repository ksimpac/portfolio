package com.example.adasl.practice1;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.content.Intent;

public class Second_page extends AppCompatActivity {

    Intent intent = new Intent();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.page2);
        setTitle("Second Page");
        Button Return = (Button)findViewById(R.id.btn_return);
        Return.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                intent.setClass(Second_page.this,MainActivity.class);
                startActivity(intent);
                setContentView(R.layout.activity_main);
                Second_page.this.finish();
            }
        });
    }
}
