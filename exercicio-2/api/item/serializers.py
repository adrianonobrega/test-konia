from rest_framework import serializers
from .models import Item



class ItemSerializer(serializers.Serializer):

    id = serializers.IntegerField(read_only=True)
    name = serializers.CharField(max_length=50)
    created_at = serializers.DateTimeField(read_only=True)

    def create(self, validated_data):
        return Item.objects.create(**validated_data)