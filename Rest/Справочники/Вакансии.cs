
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Vakansii")]
	[Route("/Catalogs/Vakansii/{Code}")]
	public class VakansiiRequest/*��������������*/: V82.�����������������.��������,IReturn<VakansiiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VakansiiResponse//�������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Vakansiis")]
	[Route("/Catalogs/Vakansiis/{Codes}")]
	public class VakansiisRequest/*��������������*/: IReturn<List<VakansiiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VakansiisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VakansiisResponse//�������������
	{
		public string Result {get;set;}
	}


	public class VakansiiService /*��������������*/ : Service
	{
		public object Any(VakansiiRequest request)
		{
			return new VakansiiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VakansiiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������.�����������(���������);
				if (������ == null)
				{
					return new VakansiiResponse() {Result = "�������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������.�����������(1);
			}
		}

		public object Get(VakansiisRequest request)
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
