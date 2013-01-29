
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NaznachenieCelevykhSredstv")]
	[Route("/Catalogs/NaznachenieCelevykhSredstv/{Code}")]
	public class NaznachenieCelevykhSredstvRequest/*������������������������������*/: V82.�����������������.������������������������,IReturn<NaznachenieCelevykhSredstvRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NaznachenieCelevykhSredstvResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NaznachenieCelevykhSredstvs")]
	[Route("/Catalogs/NaznachenieCelevykhSredstvs/{Codes}")]
	public class NaznachenieCelevykhSredstvsRequest/*������������������������������*/: IReturn<List<NaznachenieCelevykhSredstvRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NaznachenieCelevykhSredstvsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NaznachenieCelevykhSredstvsResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	public class NaznachenieCelevykhSredstvService /*������������������������������*/ : Service
	{
		public object Any(NaznachenieCelevykhSredstvRequest request)
		{
			return new NaznachenieCelevykhSredstvResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NaznachenieCelevykhSredstvRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������.�����������(���������);
				if (������ == null)
				{
					return new NaznachenieCelevykhSredstvResponse() {Result = "������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������.�����������(1);
			}
		}

		public object Get(NaznachenieCelevykhSredstvsRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������.�����������(���������);
					if (������ != null)
					{
						���������.Add(������);
					}
				}
			}
			return ���������;
		}

	}
}
