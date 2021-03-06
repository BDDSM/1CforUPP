﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//CenovyeGruppy
	[Маршрут("Справочники/ЦеновыеГруппы","")]
	public class ЦеновыеГруппыЗапрос: V82.СправочникиСсылка.ЦеновыеГруппы,IReturn<ЦеновыеГруппыЗапрос>
	{
	}
	[Маршрут("Справочники/ЦеновыеГруппы/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ЦеновыеГруппы/ПоСсылке","{Ссылка}")]
	public class ЦеновыеГруппыНайтиПоСсылке: V82.СправочникиСсылка.ЦеновыеГруппы,IReturn<ЦеновыеГруппыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ЦеновыеГруппы/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ЦеновыеГруппы/ПоКоду","{Код}")]
	public class ЦеновыеГруппыНайтиПоКоду: V82.СправочникиСсылка.ЦеновыеГруппы,IReturn<ЦеновыеГруппыНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ЦеновыеГруппы/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ЦеновыеГруппы/ПоНаименованию","{Наименование}")]
	public class ЦеновыеГруппыНайтиПоНаименованию: V82.СправочникиСсылка.ЦеновыеГруппы,IReturn<ЦеновыеГруппыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ЦеновыеГруппы/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ЦеновыеГруппы/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ЦеновыеГруппы/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ЦеновыеГруппыВыбратьПоСсылке: V82.СправочникиСсылка.ЦеновыеГруппы,IReturn<ЦеновыеГруппыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ЦеновыеГруппы/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ЦеновыеГруппы/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ЦеновыеГруппы/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ЦеновыеГруппыВыбратьПоКоду: V82.СправочникиСсылка.ЦеновыеГруппы,IReturn<ЦеновыеГруппыВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ЦеновыеГруппы/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ЦеновыеГруппы/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ЦеновыеГруппы/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ЦеновыеГруппыВыбратьПоНаименованию: V82.СправочникиСсылка.ЦеновыеГруппы,IReturn<ЦеновыеГруппыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ЦеновыеГруппы/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ЦеновыеГруппыСтраницаПоСсылке: V82.СправочникиСсылка.ЦеновыеГруппы,IReturn<ЦеновыеГруппыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ЦеновыеГруппы/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ЦеновыеГруппыСтраницаПоКоду: V82.СправочникиСсылка.ЦеновыеГруппы,IReturn<ЦеновыеГруппыСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ЦеновыеГруппы/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ЦеновыеГруппыСтраницаПоНаименованию: V82.СправочникиСсылка.ЦеновыеГруппы,IReturn<ЦеновыеГруппыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ЦеновыеГруппы/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}")]
	[Маршрут("Справочники/ЦеновыеГруппы/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ЦеновыеГруппы/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}/{___Макс}")]
	public class ЦеновыеГруппыИерархияВыбратьПоСсылке: V82.СправочникиСсылка.ЦеновыеГруппы,IReturn<ЦеновыеГруппыИерархияВыбратьПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ЦеновыеГруппы/ИерархияСтраницаПоСсылке","{___Родитель}/{___Режим}/{___Размер}/{___Номер}")]
	public class ЦеновыеГруппыИерархияСтраницаПоСсылке: V82.СправочникиСсылка.ЦеновыеГруппы,IReturn<ЦеновыеГруппыИерархияСтраницаПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ЦеновыеГруппыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ЦеновыеГруппыСервис : Service
	{
		
		public object Get(ЦеновыеГруппыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ЦеновыеГруппыНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ЦеновыеГруппы.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ЦеновыеГруппыОтвет() { Ответ = "ЦеновыеГруппы c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ЦеновыеГруппыНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ЦеновыеГруппы.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ЦеновыеГруппыОтвет() {Ответ = "ЦеновыеГруппы c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ЦеновыеГруппыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ЦеновыеГруппыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ЦеновыеГруппы.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ЦеновыеГруппыВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ЦеновыеГруппыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ЦеновыеГруппыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ЦеновыеГруппыСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ЦеновыеГруппыСтраницаПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ЦеновыеГруппыИерархияВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ЦеновыеГруппы.ИерархияВыбратьПоСсылке(Запрос.___Родитель,Запрос.___Режим,Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ЦеновыеГруппыИерархияСтраницаПоСсылке Запрос)
		{
			return null;
		}

		public object Any(ЦеновыеГруппыЗапрос Запрос)
		{
			return new ЦеновыеГруппыОтвет {Ответ = "ЦеновыеГруппы, "};
		}

		public object Post(ЦеновыеГруппыЗапрос ЗапросЦеновыеГруппы)
		{
			var Ссылка = (СправочникиСсылка.ЦеновыеГруппы)ЗапросЦеновыеГруппы;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}