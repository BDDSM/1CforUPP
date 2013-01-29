
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Subkonto")]
	[Route("/Catalogs/Subkonto/{Code}")]
	public class SubkontoRequest/*��������������*/: V82.�����������������.��������,IReturn<SubkontoRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SubkontoResponse//�������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Subkontos")]
	[Route("/Catalogs/Subkontos/{Codes}")]
	public class SubkontosRequest/*��������������*/: IReturn<List<SubkontoRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SubkontosRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SubkontosResponse//�������������
	{
		public string Result {get;set;}
	}


	public class SubkontoService /*��������������*/ : Service
	{
		public object Any(SubkontoRequest request)
		{
			return new SubkontoResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SubkontoRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������.�����������(���������);
				if (������ == null)
				{
					return new SubkontoResponse() {Result = "�������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������.�����������(1);
			}
		}

		public object Get(SubkontosRequest request)
		{
			var ��������� = new List<V82.�����������������.��������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������.�����������(���������);
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
