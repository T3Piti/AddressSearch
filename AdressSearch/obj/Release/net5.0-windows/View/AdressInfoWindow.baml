   M S B A M L   `   `   `  ���� G  CAdressSearch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AdressSearch.ViewAdressSearch.View  (    "AdressSearch.View.AdressInfoWindow   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:AdressSearch.View       � Title$*  $Информация о адресе��$	��600��$	��400��   AdressInfoWindowStyle#��[  .���  � ColumnDefinitions �� $
��0.1* ��� $��* ��� $
��0.1* � � RowDefinitions �� $
��0.1* ��� -    ��Name$ 	SecondRow��$��1* ��� $
��0.1* �.+��� $��1��$��1�� �� Orientation$ Vertical=� �� CanVerticallyScroll$
 True�� �� CanHorizontallyScroll$
 True��.+��� $��
Город����   LabelInfoStyle#��[ ���� *City+ �� Mode$ Default=��� $��Fias код города���� #��[ ���� *
FiasCity+$ Default=��� $��Fias код улицы���� #��[ ���� *
FiasStreet+$ Default=��� $ 
Horizontal=�.+��� $ Vertical=�.+��� $��Номер дома���� #��[ ���� *HouseNumber+$ Default=��� $ Vertical=�.+��� $��Корпус дома���� #��[ ���� *HouseBuilding+$ Default=��� $��Fias код дома���� #��[ ���� *	FiasHouse+$ Default=��� $!��Геоданные дома���� $ 
Horizontal=�.+��� $ Vertical=�.+��� $��Широта���� #��[ ���� *GeoHouseLat+$ Default=��� $ Vertical=�.+��� $��Долгота���� #��[ ���� *GeoHouseLon+�� $ 
Horizontal=�.+��� $ Vertical=�.+��� $��Этаж���� #��[ ���� *FloorNumber+$ Default=��� $ Vertical=�.+��� $��Подъезд���� #��[ ���� *EntranceNumber+$ Default=�