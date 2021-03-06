﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//RaschetPoModeliByudzhetirovaniya
	[Маршрут("Документы/РасчетПоМоделиБюджетирования","")]
	public class РасчетПоМоделиБюджетированияЗапрос: V82.ДокументыСсылка.РасчетПоМоделиБюджетирования,IReturn<РасчетПоМоделиБюджетированияЗапрос>
	{
	}
	[Маршрут("Документы/РасчетПоМоделиБюджетирования/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/РасчетПоМоделиБюджетирования/ПоСсылке","{Ссылка}")]
	public class РасчетПоМоделиБюджетированияНайтиПоСсылке: V82.ДокументыСсылка.РасчетПоМоделиБюджетирования,IReturn<РасчетПоМоделиБюджетированияНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/РасчетПоМоделиБюджетирования/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/РасчетПоМоделиБюджетирования/ПоНомеру","{Номер}")]
	public class РасчетПоМоделиБюджетированияНайтиПоНомеру: V82.ДокументыСсылка.РасчетПоМоделиБюджетирования,IReturn<РасчетПоМоделиБюджетированияНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/РасчетПоМоделиБюджетирования/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/РасчетПоМоделиБюджетирования/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/РасчетПоМоделиБюджетирования/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class РасчетПоМоделиБюджетированияВыбратьПоСсылке: V82.ДокументыСсылка.РасчетПоМоделиБюджетирования,IReturn<РасчетПоМоделиБюджетированияВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/РасчетПоМоделиБюджетирования/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/РасчетПоМоделиБюджетирования/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/РасчетПоМоделиБюджетирования/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class РасчетПоМоделиБюджетированияВыбратьПоНомеру: V82.ДокументыСсылка.РасчетПоМоделиБюджетирования,IReturn<РасчетПоМоделиБюджетированияВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/РасчетПоМоделиБюджетирования/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class РасчетПоМоделиБюджетированияСтраницаПоСсылке: V82.ДокументыСсылка.РасчетПоМоделиБюджетирования,IReturn<РасчетПоМоделиБюджетированияСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/РасчетПоМоделиБюджетирования/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class РасчетПоМоделиБюджетированияСтраницаПоНомеру: V82.ДокументыСсылка.РасчетПоМоделиБюджетирования,IReturn<РасчетПоМоделиБюджетированияСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class РасчетПоМоделиБюджетированияОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class РасчетПоМоделиБюджетированияСервис : Service
	{
		
		public object Get(РасчетПоМоделиБюджетированияЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(РасчетПоМоделиБюджетированияНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.РасчетПоМоделиБюджетирования.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new РасчетПоМоделиБюджетированияОтвет() { Ответ = "РасчетПоМоделиБюджетирования c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(РасчетПоМоделиБюджетированияНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.РасчетПоМоделиБюджетирования.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new РасчетПоМоделиБюджетированияОтвет() {Ответ = "РасчетПоМоделиБюджетирования c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(РасчетПоМоделиБюджетированияВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.РасчетПоМоделиБюджетирования.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(РасчетПоМоделиБюджетированияВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(РасчетПоМоделиБюджетированияСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(РасчетПоМоделиБюджетированияСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(РасчетПоМоделиБюджетированияЗапрос Запрос)
		{
			return new РасчетПоМоделиБюджетированияОтвет {Ответ = "РасчетПоМоделиБюджетирования, "};
		}

		public object Post(РасчетПоМоделиБюджетированияЗапрос ЗапросРасчетПоМоделиБюджетирования)
		{
			var Ссылка = (ДокументыСсылка.РасчетПоМоделиБюджетирования)ЗапросРасчетПоМоделиБюджетирования;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}