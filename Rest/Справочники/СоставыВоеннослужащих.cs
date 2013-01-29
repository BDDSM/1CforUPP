
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SostavyVoennosluzhashhikh")]
	[Route("/Catalogs/SostavyVoennosluzhashhikh/{Code}")]
	public class SostavyVoennosluzhashhikhRequest/*���������������������������*/: V82.�����������������.���������������������,IReturn<SostavyVoennosluzhashhikhRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SostavyVoennosluzhashhikhResponse//��������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SostavyVoennosluzhashhikhs")]
	[Route("/Catalogs/SostavyVoennosluzhashhikhs/{Codes}")]
	public class SostavyVoennosluzhashhikhsRequest/*���������������������������*/: IReturn<List<SostavyVoennosluzhashhikhRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SostavyVoennosluzhashhikhsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SostavyVoennosluzhashhikhsResponse//��������������������������
	{
		public string Result {get;set;}
	}


	public class SostavyVoennosluzhashhikhService /*���������������������������*/ : Service
	{
		public object Any(SostavyVoennosluzhashhikhRequest request)
		{
			return new SostavyVoennosluzhashhikhResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SostavyVoennosluzhashhikhRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������.�����������(���������);
				if (������ == null)
				{
					return new SostavyVoennosluzhashhikhResponse() {Result = "��������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������.�����������(1);
			}
		}

		public object Get(SostavyVoennosluzhashhikhsRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������������.�����������(���������);
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
