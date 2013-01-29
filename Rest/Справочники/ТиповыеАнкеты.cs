
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/TipovyeAnkety")]
	[Route("/Catalogs/TipovyeAnkety/{Code}")]
	public class TipovyeAnketyRequest/*�������������������*/: V82.�����������������.�������������,IReturn<TipovyeAnketyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TipovyeAnketyResponse//������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/TipovyeAnketys")]
	[Route("/Catalogs/TipovyeAnketys/{Codes}")]
	public class TipovyeAnketysRequest/*�������������������*/: IReturn<List<TipovyeAnketyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TipovyeAnketysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TipovyeAnketysResponse//������������������
	{
		public string Result {get;set;}
	}


	public class TipovyeAnketyService /*�������������������*/ : Service
	{
		public object Any(TipovyeAnketyRequest request)
		{
			return new TipovyeAnketyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TipovyeAnketyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������.�����������(���������);
				if (������ == null)
				{
					return new TipovyeAnketyResponse() {Result = "������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������.�����������(1);
			}
		}

		public object Get(TipovyeAnketysRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������.�����������(���������);
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
