﻿
using System;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceClient.Web;
using V82.Справочники;

namespace V82.Rest.СправочникиТест
{
	public class СоставОценочныхШкалКомпетенций:V82.Rest.СправочникиТест.СправочникТест
	{
		public static СоставОценочныхШкалКомпетенцийЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Справочники/СоставОценочныхШкалКомпетенций/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СоставОценочныхШкалКомпетенцийЗапрос СоставОценочныхШкалКомпетенцийЗапрос = null;
			try
			{
				СоставОценочныхШкалКомпетенцийЗапрос = Клиент.Get(new СоставОценочныхШкалКомпетенцийЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СоставОценочныхШкалКомпетенцийЗапрос;
		}
		public static СоставОценочныхШкалКомпетенцийЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Справочники/СоставОценочныхШкалКомпетенций/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СоставОценочныхШкалКомпетенцийЗапрос СоставОценочныхШкалКомпетенцийЗапрос = null;
			try
			{
				СоставОценочныхШкалКомпетенцийЗапрос = Клиент.Get(new СоставОценочныхШкалКомпетенцийЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СоставОценочныхШкалКомпетенцийЗапрос;
		}
		public static СоставОценочныхШкалКомпетенцийЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Справочники/СоставОценочныхШкалКомпетенций/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СоставОценочныхШкалКомпетенцийЗапрос СоставОценочныхШкалКомпетенцийЗапрос = null;
			try
			{
				СоставОценочныхШкалКомпетенцийЗапрос = Клиент.Get(new СоставОценочныхШкалКомпетенцийЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СоставОценочныхШкалКомпетенцийЗапрос;
		}
		public static void ЗаписатьНовый(СоставОценочныхШкалКомпетенцийЗапрос СоставОценочныхШкалКомпетенцийЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Справочники/СоставОценочныхШкалКомпетенций?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СоставОценочныхШкалКомпетенцийОтвет = Клиент.Post(СоставОценочныхШкалКомпетенцийЗапрос);
		}
		public static void Записать(СоставОценочныхШкалКомпетенцийЗапрос СоставОценочныхШкалКомпетенцийЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Справочники/СоставОценочныхШкалКомпетенций?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СоставОценочныхШкалКомпетенцийОтвет = Клиент.Put(СоставОценочныхШкалКомпетенцийЗапрос);
		}
		public static void Удалить(СоставОценочныхШкалКомпетенцийЗапрос СоставОценочныхШкалКомпетенцийЗапрос)//
		{
			var Урл = "http://localhost:1337/Справочники/СоставОценочныхШкалКомпетенций?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СоставОценочныхШкалКомпетенцийОтвет = Клиент.Delete(СоставОценочныхШкалКомпетенцийЗапрос);
		}
	}
}