﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/SostavyVoennosluzhashhikh")]
	[Route("/Catalogs/SostavyVoennosluzhashhikh/{Code}")]
	public class SostavyVoennosluzhashhikhRequest/*СоставыВоеннослужащихЗапрос*/: V82.СправочникиСсылка.СоставыВоеннослужащих,IReturn<SostavyVoennosluzhashhikhRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SostavyVoennosluzhashhikhResponse//СоставыВоеннослужащихОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SostavyVoennosluzhashhikhs")]
	[Route("/Catalogs/SostavyVoennosluzhashhikhs/{Codes}")]
	public class SostavyVoennosluzhashhikhsRequest/*СоставыВоеннослужащихЗапрос*/: IReturn<List<SostavyVoennosluzhashhikhRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SostavyVoennosluzhashhikhsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SostavyVoennosluzhashhikhsResponse//СоставыВоеннослужащихОтвет
	{
		public string Result {get;set;}
	}


	public class SostavyVoennosluzhashhikhService /*СоставыВоеннослужащихСервис*/ : Service
	{
		public object Any(SostavyVoennosluzhashhikhRequest request)
		{
			return new SostavyVoennosluzhashhikhResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SostavyVoennosluzhashhikhRequest request)
		{
			return null;
		}

		public object Get(SostavyVoennosluzhashhikhsRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.СоставыВоеннослужащих>();
			foreach (var Code in request.Codes)
			{
				decimal СтрокаКод = 0;
				if (decimal.TryParse(Code, out СтрокаКод))
				{
					Коллекция.Add(null);
				}
			}
			return Коллекция;
		}

	}
}
