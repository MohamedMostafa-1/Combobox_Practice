# PictureBox Practice 🖼️

A simple **C# Windows Forms** project for practicing how to use the **PictureBox** and **ComboBox** controls and handle selection events.

## 📸 Project Preview

<img width="795" height="449" alt="PictureBox Practice" src="https://github.com/user-attachments/assets/734b14ab-531d-4457-85df-20651561b5d2" />


## ✨ Features

- 🧑 **Boy** → Displays the Boy image.
- 👧 **Girl** → Displays the Girl image.
- 📖 **Book** → Displays the Book image.
- 🖊️ **Pen** → Displays the Pen image.
- 🔽 Uses a **ComboBox** to select the desired image.
- 🖼️ Uses a **PictureBox** to display the selected image.
- 🖱️ Uses the **SelectedIndexChanged** event to change the displayed image.
- 📦 Uses project **Resources** to store and display images.

## 🛠️ Technologies Used

- C#
- Windows Forms
- .NET
- Visual Studio

## 📚 What I Practiced

Through this project, I practiced:

- Working with the `PictureBox` control.
- Working with the `ComboBox` control.
- Adding and selecting items from a `ComboBox`.
- Handling the `SelectedIndexChanged` event.
- Changing images dynamically based on the selected item.
- Changing the `Label` text dynamically.
- Using project **Resources** to store and display images.

## 💻 Example

```csharp
private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
{
    switch (comboBox1.SelectedItem.ToString())
    {
        case "Boy":
            LblTital.Text = "Boy";
            pictureBox1.Image = Resources.Boy;
            break;

        case "Girl":
            LblTital.Text = "Girl";
            pictureBox1.Image = Resources.Girl;
            break;

        case "Book":
            LblTital.Text = "Book";
            pictureBox1.Image = Resources.Book;
            break;

        case "Pen":
            LblTital.Text = "Pen";
            pictureBox1.Image = Resources.Pen;
            break;
    }
}
