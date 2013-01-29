
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/GruppyPisemEHlektronnojjPochty")]
	[Route("/Catalogs/GruppyPisemEHlektronnojjPochty/{Code}")]
	public class GruppyPisemEHlektronnojjPochtyRequest/*���������������������������������*/: V82.�����������������.���������������������������,IReturn<GruppyPisemEHlektronnojjPochtyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class GruppyPisemEHlektronnojjPochtyResponse//��������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/GruppyPisemEHlektronnojjPochtys")]
	[Route("/Catalogs/GruppyPisemEHlektronnojjPochtys/{Codes}")]
	public class GruppyPisemEHlektronnojjPochtysRequest/*���������������������������������*/: IReturn<List<GruppyPisemEHlektronnojjPochtyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public GruppyPisemEHlektronnojjPochtysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class GruppyPisemEHlektronnojjPochtysResponse//��������������������������������
	{
		public string Result {get;set;}
	}


	public class GruppyPisemEHlektronnojjPochtyService /*���������������������������������*/ : Service
	{
		public object Any(GruppyPisemEHlektronnojjPochtyRequest request)
		{
			return new GruppyPisemEHlektronnojjPochtyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(GruppyPisemEHlektronnojjPochtyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������������.�����������(���������);
				if (������ == null)
				{
					return new GruppyPisemEHlektronnojjPochtyResponse() {Result = "��������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������������.�����������(1);
			}
		}

		public object Get(GruppyPisemEHlektronnojjPochtysRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������������������.�����������(���������);
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
