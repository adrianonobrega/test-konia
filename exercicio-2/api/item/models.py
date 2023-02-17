from django.db import models

# Create your models here.

class Item(models.Model):

    id = models.AutoField(primary_key=True)
    name = models.CharField(max_length=50)
    created_at = models.DateTimeField(auto_now_add=True)
