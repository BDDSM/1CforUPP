﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.ДокументыСсылка;
using V82.Документы;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Документы//Менеджер
{
	///<summary>
	///(Регл)
	///</summary>
	public partial class РеестрДСВ3:ДокументМенеджер
	{
		
		public static ДокументыСсылка.РеестрДСВ3 НайтиПоСсылке(Guid _Ссылка)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld24963 [ПериодРегистрации]
					,_Fld24964RRef [Организация]
					,_Fld24965RRef [Ответственный]
					,_Fld24966 [Комментарий]
					,_Fld24967 [КраткийСоставДокумента]
					,_Fld24968RRef [ФорматФайла]
					,_Fld24969 [НомерПлатежногоПоручения]
					,_Fld24970 [ДатаПлатежногоПоручения]
					,_Fld24971 [ДатаИсполненияПлатежногоПоручения]
					,_Fld24972 [НомерПачки]
					From _Document23166(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РеестрДСВ3();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРегистрации = Читалка.GetDateTime(3);
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(7);
							Ссылка.ФорматФайла = V82.Перечисления/*Ссылка*/.ФорматФайлаПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.НомерПлатежногоПоручения = Читалка.GetString(9);
							Ссылка.ДатаПлатежногоПоручения = Читалка.GetDateTime(10);
							Ссылка.ДатаИсполненияПлатежногоПоручения = Читалка.GetDateTime(11);
							Ссылка.НомерПачки = Читалка.GetString(12);
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}
		
		public static ДокументыСсылка.РеестрДСВ3 НайтиПоНомеру(string Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld24963 [ПериодРегистрации]
					,_Fld24964RRef [Организация]
					,_Fld24965RRef [Ответственный]
					,_Fld24966 [Комментарий]
					,_Fld24967 [КраткийСоставДокумента]
					,_Fld24968RRef [ФорматФайла]
					,_Fld24969 [НомерПлатежногоПоручения]
					,_Fld24970 [ДатаПлатежногоПоручения]
					,_Fld24971 [ДатаИсполненияПлатежногоПоручения]
					,_Fld24972 [НомерПачки]
					From _Document23166(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РеестрДСВ3();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРегистрации = Читалка.GetDateTime(3);
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(7);
							Ссылка.ФорматФайла = V82.Перечисления/*Ссылка*/.ФорматФайлаПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.НомерПлатежногоПоручения = Читалка.GetString(9);
							Ссылка.ДатаПлатежногоПоручения = Читалка.GetDateTime(10);
							Ссылка.ДатаИсполненияПлатежногоПоручения = Читалка.GetDateTime(11);
							Ссылка.НомерПачки = Читалка.GetString(12);
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}
		
		public static ДокументыВыборка.РеестрДСВ3 Выбрать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld24963 [ПериодРегистрации]
					,_Fld24964RRef [Организация]
					,_Fld24965RRef [Ответственный]
					,_Fld24966 [Комментарий]
					,_Fld24967 [КраткийСоставДокумента]
					,_Fld24968RRef [ФорматФайла]
					,_Fld24969 [НомерПлатежногоПоручения]
					,_Fld24970 [ДатаПлатежногоПоручения]
					,_Fld24971 [ДатаИсполненияПлатежногоПоручения]
					,_Fld24972 [НомерПачки]
					From _Document23166(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.РеестрДСВ3();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РеестрДСВ3();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРегистрации = Читалка.GetDateTime(3);
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(7);
							Ссылка.ФорматФайла = V82.Перечисления/*Ссылка*/.ФорматФайлаПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.НомерПлатежногоПоручения = Читалка.GetString(9);
							Ссылка.ДатаПлатежногоПоручения = Читалка.GetDateTime(10);
							Ссылка.ДатаИсполненияПлатежногоПоручения = Читалка.GetDateTime(11);
							Ссылка.НомерПачки = Читалка.GetString(12);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.РеестрДСВ3 ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld24963 [ПериодРегистрации]
					,_Fld24964RRef [Организация]
					,_Fld24965RRef [Ответственный]
					,_Fld24966 [Комментарий]
					,_Fld24967 [КраткийСоставДокумента]
					,_Fld24968RRef [ФорматФайла]
					,_Fld24969 [НомерПлатежногоПоручения]
					,_Fld24970 [ДатаПлатежногоПоручения]
					,_Fld24971 [ДатаИсполненияПлатежногоПоручения]
					,_Fld24972 [НомерПачки]
					From _Document23166(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.РеестрДСВ3();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РеестрДСВ3();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРегистрации = Читалка.GetDateTime(3);
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(7);
							Ссылка.ФорматФайла = V82.Перечисления/*Ссылка*/.ФорматФайлаПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.НомерПлатежногоПоручения = Читалка.GetString(9);
							Ссылка.ДатаПлатежногоПоручения = Читалка.GetDateTime(10);
							Ссылка.ДатаИсполненияПлатежногоПоручения = Читалка.GetDateTime(11);
							Ссылка.НомерПачки = Читалка.GetString(12);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.РеестрДСВ3 ВыбратьПоНомеру(int Первые,string Мин,string Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld24963 [ПериодРегистрации]
					,_Fld24964RRef [Организация]
					,_Fld24965RRef [Ответственный]
					,_Fld24966 [Комментарий]
					,_Fld24967 [КраткийСоставДокумента]
					,_Fld24968RRef [ФорматФайла]
					,_Fld24969 [НомерПлатежногоПоручения]
					,_Fld24970 [ДатаПлатежногоПоручения]
					,_Fld24971 [ДатаИсполненияПлатежногоПоручения]
					,_Fld24972 [НомерПачки]
					From _Document23166(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.РеестрДСВ3();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РеестрДСВ3();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРегистрации = Читалка.GetDateTime(3);
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(7);
							Ссылка.ФорматФайла = V82.Перечисления/*Ссылка*/.ФорматФайлаПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.НомерПлатежногоПоручения = Читалка.GetString(9);
							Ссылка.ДатаПлатежногоПоручения = Читалка.GetDateTime(10);
							Ссылка.ДатаИсполненияПлатежногоПоручения = Читалка.GetDateTime(11);
							Ссылка.НомерПачки = Читалка.GetString(12);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.РеестрДСВ3 СтраницаПоСсылке(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld24963 [ПериодРегистрации]
					,_Fld24964RRef [Организация]
					,_Fld24965RRef [Ответственный]
					,_Fld24966 [Комментарий]
					,_Fld24967 [КраткийСоставДокумента]
					,_Fld24968RRef [ФорматФайла]
					,_Fld24969 [НомерПлатежногоПоручения]
					,_Fld24970 [ДатаПлатежногоПоручения]
					,_Fld24971 [ДатаИсполненияПлатежногоПоручения]
					,_Fld24972 [НомерПачки]
					From _Document23166(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.РеестрДСВ3();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РеестрДСВ3();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРегистрации = Читалка.GetDateTime(3);
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(7);
							Ссылка.ФорматФайла = V82.Перечисления/*Ссылка*/.ФорматФайлаПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.НомерПлатежногоПоручения = Читалка.GetString(9);
							Ссылка.ДатаПлатежногоПоручения = Читалка.GetDateTime(10);
							Ссылка.ДатаИсполненияПлатежногоПоручения = Читалка.GetDateTime(11);
							Ссылка.НомерПачки = Читалка.GetString(12);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.РеестрДСВ3 СтраницаПоНомеру(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld24963 [ПериодРегистрации]
					,_Fld24964RRef [Организация]
					,_Fld24965RRef [Ответственный]
					,_Fld24966 [Комментарий]
					,_Fld24967 [КраткийСоставДокумента]
					,_Fld24968RRef [ФорматФайла]
					,_Fld24969 [НомерПлатежногоПоручения]
					,_Fld24970 [ДатаПлатежногоПоручения]
					,_Fld24971 [ДатаИсполненияПлатежногоПоручения]
					,_Fld24972 [НомерПачки]
					From _Document23166(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.РеестрДСВ3();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РеестрДСВ3();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРегистрации = Читалка.GetDateTime(3);
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(7);
							Ссылка.ФорматФайла = V82.Перечисления/*Ссылка*/.ФорматФайлаПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.НомерПлатежногоПоручения = Читалка.GetString(9);
							Ссылка.ДатаПлатежногоПоручения = Читалка.GetDateTime(10);
							Ссылка.ДатаИсполненияПлатежногоПоручения = Читалка.GetDateTime(11);
							Ссылка.НомерПачки = Читалка.GetString(12);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.РеестрДСВ3 СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.РеестрДСВ3();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.КраткийСоставДокумента = "";
			Объект.НомерПлатежногоПоручения = "";
			Объект.НомерПачки = "";
			Объект.ФорматФайла = V82.Перечисления/*Ссылка*/.ФорматФайлаПФР.ПустаяСсылка;
			return Объект;
		}
	}
}