# Generated by Django 4.1.7 on 2023-02-15 13:21

from django.db import migrations, models


class Migration(migrations.Migration):
    dependencies = [
        ("item", "0003_alter_item_created_at_alter_item_id"),
    ]

    operations = [
        migrations.AlterField(
            model_name="item",
            name="id",
            field=models.AutoField(primary_key=True, serialize=False),
        ),
    ]
