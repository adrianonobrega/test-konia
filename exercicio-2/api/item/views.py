from django.shortcuts import render
from rest_framework.views import APIView,Request,Response, status
from .serializers import ItemSerializer
from .models import Item
from django.forms.models import model_to_dict

# Create your views here.
class ItemView(APIView):
    def post(self, request: Request):
        
        serializer = ItemSerializer(data=request.data)
        serializer.is_valid(raise_exception=True)
        serializer.create
        serializer.save()
        
        return Response(serializer.data, status.HTTP_201_CREATED)
    
    def get(self,request: Request):
        items = Item.objects.all()
        
        return Response(items.values())