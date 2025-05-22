# 2D Mátrix GUI

```c#
CheckBox[,] checkBoxes = new CheckBox[keytoDictionary, 27];
            for (int i = 0; i < keytoDictionary; i++)
            {
                Label label = new Label();
                label.Location = new Point(25 + i * 20, 0);
                label.Size = new Size(20, 20);
                label.Text = (i + 1).ToString();
                panel.Controls.Add(label);
                for (int j = 0; j < 27; j++)
                {
                    if (i == 0)
                    {
                        Label label1 = new Label();
                        label1.Location = new Point(0, 26 + j * 20);
                        label1.Size = new Size(20, 18);
                        label1.Text = (j + 1).ToString();
                        panel.Controls.Add(label1);
                    }

                    checkBoxes[i, j] = new CheckBox();
                    checkBoxes[i, j].Location = new Point(25 + i * 20, 25 + j * 20);
                    checkBoxes[i, j].Size = new Size(20, 20);
                    checkBoxes[i, j].Text = (j + 1).ToString();
                    panel.Controls.Add(checkBoxes[i, j]);


                    checkBoxes[i, j].BackColor = Color.Green;

                }
            }
```